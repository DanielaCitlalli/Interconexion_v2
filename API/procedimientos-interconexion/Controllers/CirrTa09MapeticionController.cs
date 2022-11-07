using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using procedimientos_interconexion.Models;

namespace procedimientos_interconexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CirrTa09MapeticionController : ControllerBase
    {
        private readonly InterconexionContext _context;

        public CirrTa09MapeticionController(InterconexionContext context)
        {
            _context = context;
        }

        // GET: api/CirrTa09Mapeticion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CirrTa09Mapeticion>>> GetCirrTa09Mapeticion()
        {
            return await _context.CirrTa09Mapeticion.ToListAsync();
        }

        // GET: api/CirrTa09Mapeticion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CirrTa09Mapeticion>> GetCirrTa09MapeticionId(decimal id)
        {
            var cirrTa09Mapeticion = await _context.CirrTa09Mapeticion.FindAsync(id);

            if (cirrTa09Mapeticion == null)
            {
                return NotFound();
            }

            return cirrTa09Mapeticion;
        }

        [HttpGet]
        [Route("buscarcadena/{crip}")]
        public async Task<ActionResult<List<NrcMatrimonios>>> buscarCadena(string crip)
        {
            try
            {
                var res = _context.NrcMatrimonios.FromSqlInterpolated($@"EXEC dbo.cripToCadenaMat @crip={crip}").AsAsyncEnumerable();

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        // PUT: api/CirrTa09Mapeticion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCirrTa09Mapeticion(decimal id, CirrTa09Mapeticion cirrTa09Mapeticion)
        {
            if (id != cirrTa09Mapeticion.Ta09EOid)
            {
                return BadRequest();
            }

            _context.Entry(cirrTa09Mapeticion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CirrTa09MapeticionExists(id))
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

        // POST: api/CirrTa09Mapeticion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CirrTa09Mapeticion>> PostCirrTa09Mapeticion(CirrTa09Mapeticion cirrTa09Mapeticion)
        {
            //Borrar matrimonios
            try
            {
                //_context.Add(new CirrTa09Mapeticion { Ta09EPrioridad = 1, Ta09EOperacionacto = 2, Ta09EEstatus = 0, Ta09ECuantos = 0, Ta09CCadena = cirrTa09Mapeticion.Ta09CCadena });
                _context.Add(cirrTa09Mapeticion);
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                if(cirrTa09Mapeticion.Ta09EPrioridad == 1 && cirrTa09Mapeticion.Ta09EOperacionacto == 1 && cirrTa09Mapeticion.Ta09EEstatus == 0 && cirrTa09Mapeticion.Ta09ECuantos == 0)
                {
                    oLog.Add(remoteIpAddress + " - " + "Se actualizo registro  " + " - " + cirrTa09Mapeticion.Ta09CCadena);
                }
                else
                {
                    oLog.Add(remoteIpAddress + " - " + "Se Borro Matrimonios  " + " - " + cirrTa09Mapeticion.Ta09CCadena);
                }
               

                return CreatedAtAction(nameof(GetCirrTa09MapeticionId), new { id = cirrTa09Mapeticion.Ta09EOid }, cirrTa09Mapeticion);

                //return Content("El registro se agregó exitosamente");
            }
            catch (Exception ex)
            {
                return BadRequest();
                //return Content("Ocurrio un error al hacer el registro: " + ex, "application/json");
            }



        }


        [Route("SubirActaMatrimonio")]
        public async Task<ActionResult<CirrTa09Mapeticion>> PostCirrTa09Mapeticion1(CirrTa09Mapeticion cirrTa09Mapeticion)
        {
            //FORZAR SUBIR ACTA MATRIMONIOS

            try
            {
                _context.Add(cirrTa09Mapeticion);
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " - " + "Se subio Acta de Matrimonio  " + " - " + cirrTa09Mapeticion.Ta09CCadena);

                return CreatedAtAction(nameof(GetCirrTa09MapeticionId), new { id = cirrTa09Mapeticion.Ta09EOid }, cirrTa09Mapeticion);
                //return Content("El registro se agregó exitosamente", "application/json");
            }
            catch (Exception ex)
            {
                return BadRequest();
                //return Content("Ocurrio un error al hacer el registro: " + ex, "application/json");
            }


        }


        // DELETE: api/CirrTa09Mapeticion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CirrTa09Mapeticion>> DeleteCirrTa09Mapeticion(decimal id)
        {
            var cirrTa09Mapeticion = await _context.CirrTa09Mapeticion.FindAsync(id);
            if (cirrTa09Mapeticion == null)
            {
                return NotFound();
            }

            _context.CirrTa09Mapeticion.Remove(cirrTa09Mapeticion);
            await _context.SaveChangesAsync();

            return cirrTa09Mapeticion;
        }

        private bool CirrTa09MapeticionExists(decimal id)
        {
            return _context.CirrTa09Mapeticion.Any(e => e.Ta09EOid == id);
        }
    }
}
