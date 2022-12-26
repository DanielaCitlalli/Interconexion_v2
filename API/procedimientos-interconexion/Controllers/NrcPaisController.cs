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
    public class NrcPaisController : ControllerBase
    {
        private readonly InterconexionContext _context;

        public NrcPaisController(InterconexionContext context)
        {
            _context = context;

        }

        // GET: api/NrcPais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NrcNacionalidad>>> GetNrcNacionalidad()
        {
            try
            {
                return await _context.NrcNacionalidad.ToListAsync();
            }
            catch
            {
                return BadRequest("Error al obtener lista de paises");
            }
        }

        // GET: api/NrcPais/5
        [HttpGet("{codigo}")]
        public async Task<ActionResult<NrcNacionalidad>> GetNrcNacionalidadId(decimal codigo)
        {
            //Si se desea hacer una busqueda, se debe definir primero una primary key para usar FindAsync. La tabla no tiene. 

            try
            {
                var nrcNacionalidad = await _context.NrcNacionalidad.FindAsync(codigo);

                return nrcNacionalidad;
            }
            catch
            {
                return NotFound("No se encontró el registro indicado...");
            }

        }

        // GET: api/NrcPais/5
        [HttpGet("busquedaPais/{desc}")]
        public async Task<ActionResult<NrcNacionalidad>> GetNrcNacionalidadDesc(string desc)
        {
            //BUSQUEDA POR COINCIDENCIA

            try
            {

                var res = await (from _NrcNacionalidad in _context.NrcNacionalidad where EF.Functions.Like(_NrcNacionalidad.PaiDescripcion, $"{desc}%") 
                                 select new { 
                                     _NrcNacionalidad.PaiCodigo,
                                     _NrcNacionalidad.PaiNacionalidad,
                                     _NrcNacionalidad.PaiDescripcion,
                                     _NrcNacionalidad.PaiUsuarioCreacion,
                                     _NrcNacionalidad.PaiFechaCreacion,
                                     _NrcNacionalidad.PaiUsuarioModificacion,
                                     _NrcNacionalidad.PaiFechaModificacion,
                                     _NrcNacionalidad.PaiCveNacionalidad
                                 }).ToListAsync();

                return Ok(res);

            }
            catch (Exception ex)
            {
                return BadRequest("No se encontró el registro indicado..." + ex.Message);
            }


        }

        // POST: api/NrcPais
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NrcNacionalidad>> PostNrcNacionalidad(NrcNacionalidad nrcNacionalidad)
        {
            try
            {

                _context.Add(nrcNacionalidad);

                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " , " + "Se agregó nueva nacionalidad" + " , " + nrcNacionalidad.PaiCodigo);


                return CreatedAtAction(nameof(GetNrcNacionalidadId), new { codigo = nrcNacionalidad.PaiCodigo}, nrcNacionalidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/NrcPais/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{codigo}")]
        public async Task<IActionResult> PutNrcNacionalidad(decimal codigo, NrcNacionalidad nrcNacionalidad)
        {
            if (codigo != nrcNacionalidad.PaiCodigo)
            {
                return BadRequest();
            }




            try
            {
                _context.Entry(nrcNacionalidad).State = EntityState.Modified;
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " , " + "Se actualizó Nacionalidad" + " , " + nrcNacionalidad.PaiCodigo);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NrcNacionalidadExists(codigo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();
            return CreatedAtAction(nameof(GetNrcNacionalidadId), new { codigo = nrcNacionalidad.PaiCodigo}, nrcNacionalidad);
        }


        private bool NrcNacionalidadExists(decimal id)
        {
            return _context.NrcPais.Any(e => e.PaiCodigo == id);
        }
    }
}
