using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using procedimientos_interconexion.Models;

namespace procedimientos_interconexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CirrTa03DepeticionController : ControllerBase
    {
        private readonly InterconexionContext _context;
          

        public CirrTa03DepeticionController(InterconexionContext context)
        {
            _context = context;
        }

        // GET: api/CirrTa03Depeticion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CirrTa03Depeticion>>> GetCirrTa03Depeticion()
        {
            return await _context.CirrTa03Depeticion.ToListAsync();
        }

        // GET: api/CirrTa03Depeticion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CirrTa03Depeticion>> GetCirrTa03DepeticionId(decimal id)
        {
            var cirrTa03Depeticion = await _context.CirrTa03Depeticion.FindAsync(id);

            if (cirrTa03Depeticion == null)
            {
                return NotFound();
            }

            return cirrTa03Depeticion;
        }
        [HttpGet]
        [Route("buscarcadena/{crip}")]
        public async Task<ActionResult<List<NrcDefunciones>>> buscarCadena(string crip)
        {
            try
            {
                var res = _context.NrcDefunciones.FromSqlInterpolated($@"EXEC dbo.cripToCadenaDef @crip={crip}").AsAsyncEnumerable();

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest();
  
            }

    }
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext()
            {
                Database.SetCommandTimeout(150000);
            }
        }

        // PUT: api/CirrTa03Depeticion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCirrTa03Depeticion(decimal id, CirrTa03Depeticion cirrTa03Depeticion)
        {
            if (id != cirrTa03Depeticion.Ta03EOid)
            {
                return BadRequest();
            }

            _context.Entry(cirrTa03Depeticion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CirrTa03DepeticionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CirrTa03Depeticion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CirrTa03Depeticion>> PostCirrTa03Depeticion(CirrTa03Depeticion cirrTa03Depeticion)
        {
            //Borrar DEfunciones

            try
            {
                //_context.Add(new CirrTa03Depeticion { Ta03EPrioridad = 1, Ta03EOperacionacto = 2, Ta03EEstatus = 0, Ta03ECuantos = 0, Ta03CCadena = cirrTa03Depeticion.Ta03CCadena });
                _context.Add(cirrTa03Depeticion);
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " - " + "Se borro defunción " + " - " + cirrTa03Depeticion.Ta03CCadena);

                return CreatedAtAction(nameof(GetCirrTa03DepeticionId), new { id = cirrTa03Depeticion.Ta03EOid }, cirrTa03Depeticion);
            }
            catch (Exception ex)
            {
                return BadRequest();
                //return Content("Ocurrio un error al hacer el registro: " + ex, "application/json");
            }


        }

        [Route("SubirActaDefunciones")]
        public async Task<ActionResult<CirrTa03Depeticion>> PostCirrTa03Depeticion1(CirrTa03Depeticion cirrTa03Depeticion)
        {
            //FORZAR SUBIR ACTA DEFUNCIONES

            try
            {
                _context.Add(cirrTa03Depeticion);
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " - " + "Se subio Acta de Defunción " + " - " + cirrTa03Depeticion.Ta03CCadena);

                return CreatedAtAction(nameof(GetCirrTa03DepeticionId), new { id = cirrTa03Depeticion.Ta03EOid }, cirrTa03Depeticion);
            }
            catch(Exception ex)
            {
                return BadRequest();
                //return Content("Ocurrio un error al hacer el registro: " + ex, "application/json");
            }


        }

        // DELETE: api/CirrTa03Depeticion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CirrTa03Depeticion>> DeleteCirrTa03Depeticion(decimal id)
        {
            var cirrTa03Depeticion = await _context.CirrTa03Depeticion.FindAsync(id);
            if (cirrTa03Depeticion == null)
            {
                return NotFound();
            }

            _context.CirrTa03Depeticion.Remove(cirrTa03Depeticion);
            await _context.SaveChangesAsync();

            return cirrTa03Depeticion;
        }

        private bool CirrTa03DepeticionExists(decimal id)
        {
            return _context.CirrTa03Depeticion.Any(e => e.Ta03EOid == id);
        }
    }
}
