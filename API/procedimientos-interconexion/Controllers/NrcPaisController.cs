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
        public async Task<ActionResult<IEnumerable<NrcPais>>> GetNrcPais()
        {
            try
            {
                return await _context.NrcPais.ToListAsync();
            }
            catch
            {
                return BadRequest("Error al obtener lista de paises");
            }
        }

        // GET: api/NrcPais/5
        [HttpGet("{codigo}")]
        public async Task<ActionResult<NrcPais>> GetNrcPaisId(decimal codigo)
        {
            //Si se desea hacer una busqueda, se debe definir primero una primary key para usar FindAsync. La tabla no tiene. 

            try
            {
                var nrcPais = await _context.NrcPais.FindAsync(codigo);

                return nrcPais;
            }
            catch
            {
                return NotFound("No se encontró el registro indicado...");
            }

        }

        // GET: api/NrcPais/5
        [HttpGet("busquedaPais/{desc}")]
        public async Task<ActionResult<NrcPais>> GetNrcPaisDesc(string desc)
        {
            //BUSQUEDA POR COINCIDENCIA

            try
            {

                var res = await (from _NrcPais in _context.NrcPais where EF.Functions.Like(_NrcPais.PaiDescripcion, $"{desc}%") 
                                 select new { 
                                     _NrcPais.PaiCodigo,
                                     _NrcPais.PaiNacionalidad,
                                     _NrcPais.PaiDescripcion,
                                     _NrcPais.PaiUsuarioCreacion,
                                     _NrcPais.PaiFechaCreacion,
                                     _NrcPais.PaiUsuarioModificacion,
                                     _NrcPais.PaiFechaModificacion,
                                     _NrcPais.PaiCveNacionalidad
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
        public async Task<ActionResult<NrcPais>> PostNrcPais(NrcPais nrcPais)
        {
            try
            {

                _context.Add(nrcPais);

                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " , " + "Se agregó nuevo país" + " , " + nrcPais.PaiCodigo);


                return CreatedAtAction(nameof(GetNrcPaisId), new { codigo = nrcPais.PaiCodigo}, nrcPais);
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
        public async Task<IActionResult> PutNrcPais(decimal codigo, NrcPais nrcPais)
        {
            if (codigo != nrcPais.PaiCodigo)
            {
                return BadRequest();
            }




            try
            {
                _context.Entry(nrcPais).State = EntityState.Modified;
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " , " + "Se actualizó Pais" + " , " + nrcPais.PaiCodigo);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NrcPaisExists(codigo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();
            return CreatedAtAction(nameof(GetNrcPaisId), new { codigo = nrcPais.PaiCodigo}, nrcPais);
        }

        private bool NrcPaisExists(decimal id)
        {
            return _context.NrcPais.Any(e => e.PaiCodigo == id);
        }
    }
}
