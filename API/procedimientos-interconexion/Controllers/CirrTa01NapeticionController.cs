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
    public class CirrTa01NapeticionController : ControllerBase
    {
        private readonly InterconexionContext _context;

        public CirrTa01NapeticionController(InterconexionContext context)
        {
            _context = context;
            
        }
        // holaaaaa
        // GET: api/CirrTa01Napeticion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CirrTa01Napeticion>>> GetCirrTa01Napeticion()
        {
            return await _context.CirrTa01Napeticion.ToListAsync();
        }

        // GET: api/CirrTa01Napeticion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CirrTa01Napeticion>> GetCirrTa01NapeticionId(decimal id)
        {
            var cirrTa01Napeticion = await _context.CirrTa01Napeticion.FindAsync(id);

            if (cirrTa01Napeticion == null)
            {
                return NotFound();
            }

            return cirrTa01Napeticion;
        }

        // PUT: api/CirrTa01Napeticion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCirrTa01Napeticion(decimal id, CirrTa01Napeticion cirrTa01Napeticion)
        {
           
            if (id != cirrTa01Napeticion.Ta01EOid)
            {
                return BadRequest();
                
            }

            _context.Entry(cirrTa01Napeticion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CirrTa01NapeticionExists(id))
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

        // POST: api/CirrTa01Napeticion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CirrTa01Napeticion>> PostCirrTa01Napeticion(CirrTa01Napeticion cirrTa01Napeticion)
        {
            //_context.CirrTa01Napeticion.Add(cirrTa01Napeticion);
            //await _context.SaveChangesAsync();

            // BORRAR NACIMIENTOS

            try
            {
                //_context.Add(new CirrTa01Napeticion { 
                //    Ta01ESecuencia = cirrTa01Napeticion.Ta01ESecuencia,
                //    Ta01EPrioridad = cirrTa01Napeticion.Ta01EPrioridad, 
                //    Ta01EOperacionacto = cirrTa01Napeticion.Ta01EOperacionacto,
                //    Ta01CCadena = cirrTa01Napeticion.Ta01CCadena,
                //    Ta01FEntrada = cirrTa01Napeticion.Ta01FEntrada,
                //    Ta01EEstatus = cirrTa01Napeticion.Ta01EEstatus,
                //    Ta07EEstadodest = cirrTa01Napeticion.Ta07EEstadodest,
                //    Ta07EOiddestino = cirrTa01Napeticion.Ta07EOiddestino,
                //    Ta07ESolicitarimagen = cirrTa01Napeticion.Ta07ESolicitarimagen,
                //    Ta01FAtencion = cirrTa01Napeticion.Ta01FAtencion,
                //    Ta01ECuantos = cirrTa01Napeticion.Ta01ECuantos
                //});

                _context.Add(cirrTa01Napeticion);
                    
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress=HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " - " + "Se borro Nacimiento" + " - " + cirrTa01Napeticion.Ta01CCadena);
       
                //return NoContent();
                //return Content("El registro se agregó exitosamente", "application/json");
                //Consulta para encontrar el ultimo id ingresado a alguna tabla
                //var lastId = await _context.CirrTa01Napeticion.FromSqlRaw("SELECT IDENT_CURRENT('CIRR_TA01_NAPETICION') as TA01_E_OID").ToListAsync();



                return CreatedAtAction(nameof(GetCirrTa01NapeticionId), new { id = cirrTa01Napeticion.Ta01EOid }, cirrTa01Napeticion);
            }
            catch (Exception ex)
            {
                return BadRequest();
                //return Content("Ocurrio un error al hacer el registro: " +  ex, "application/json");
            }



            //await _context.SaveChangesAsync();
            //return CreatedAtAction("GetCirrTa01Napeticion", new { id = cirrTa01Napeticion.Ta01EOid }, cirrTa01Napeticion);

            }

        [HttpPost]
        [Route("ForzarSubirActaNacimientos")]
        public async Task<ActionResult<CirrTa01Napeticion>> PostCirrTa01Napeticion02(CirrTa01Napeticion cirrTa01Napeticion)
        {
            //_context.CirrTa01Napeticion.Add(cirrTa01Napeticion);
            //await _context.SaveChangesAsync();

            try
            {
                //_context.Add(new CirrTa01Napeticion { Ta01EPrioridad = 1, Ta01EOperacionacto = 1, Ta01CCadena = cirrTa01Napeticion.Ta01CCadena, Ta01EEstatus = 0, Ta01ECuantos = 0 });
                _context.CirrTa01Napeticion.Add(cirrTa01Napeticion);
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " - " + "Se subio Acta de nacimiento " + " - " + cirrTa01Napeticion.Ta01CCadena);


                return CreatedAtAction(nameof(GetCirrTa01NapeticionId), new { id = cirrTa01Napeticion.Ta01EOid }, cirrTa01Napeticion);
                //return NoContent();
            }
            catch(Exception ex){
                return BadRequest();
                //return Content("Ocurrio un error al hacer el registro: " + ex, "application/json");
            }



            //await _context.SaveChangesAsync();
            //return CreatedAtAction("GetCirrTa01Napeticion", new { id = cirrTa01Napeticion.Ta01EOid }, cirrTa01Napeticion);

        }


        // DELETE: api/CirrTa01Napeticion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CirrTa01Napeticion>> DeleteCirrTa01Napeticion(decimal id)
        {
            var cirrTa01Napeticion = await _context.CirrTa01Napeticion.FindAsync(id);
            if (cirrTa01Napeticion == null)
            {
                return NotFound();
            }

            _context.CirrTa01Napeticion.Remove(cirrTa01Napeticion);
            await _context.SaveChangesAsync();

            return cirrTa01Napeticion;
        }

        private bool CirrTa01NapeticionExists(decimal id)
        {
            return _context.CirrTa01Napeticion.Any(e => e.Ta01EOid == id);
        }
    }
}
