using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using procedimientos_interconexion.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace procedimientos_interconexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NrcNacimientosController : ControllerBase
    {
        private readonly InterconexionContext _context;

        public NrcNacimientosController(InterconexionContext context)
        {
            _context = context;

        }

        [HttpGet("{cadena}")]
        public async Task<ActionResult<NrcNacimientos>> GetNrcNacimientosId(string cadena)
        {
            //Si se desea hacer una busqueda, se debe definir primero una primary key para usar FindAsync. La tabla no tiene. 

            try
            {
                var nrcNacimientos = await _context.NrcNacimientos.FindAsync(cadena);

                return nrcNacimientos;
            }
            catch
            {
                return NotFound("No se encontró el registro indicado...");
            }

        }

        // PUT: api/NrcPais/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{cadena}")]
        public async Task<IActionResult> PutNrcPais(string cadena, NrcNacimientos nrcNacimientos)
        {
            if (cadena != nrcNacimientos.Cadena)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(nrcNacimientos).State = EntityState.Modified;
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " , " + "Se actualizó nacionalidad" + " , " + nrcNacimientos.Cadena);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NrcNacimientosExists(cadena))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();
            return CreatedAtAction(nameof(GetNrcNacimientosId), new { cadena = nrcNacimientos.Cadena}, nrcNacimientos);
        }

        private bool NrcNacimientosExists(string cadena)
        {
            return _context.NrcNacimientos.Any(e => e.Cadena == cadena);
        }
    }
}
