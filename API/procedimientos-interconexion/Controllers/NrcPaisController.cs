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
            return await _context.NrcPais.ToListAsync();
        }

        // GET: api/NrcPais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NrcPais>> GetNrcPaisId(decimal id)
        {
            //Si se desea hacer una busqueda, se debe definir primero una primary key para usar FindAsync. La tabla no tiene. 
            var nrcPais = await _context.NrcPais.FindAsync(id);
            Console.WriteLine(nrcPais);

            if (nrcPais == null)
            {
                return NotFound("No se encontró el registro indicado...");

            }

            return nrcPais;
        }

        // POST: api/NrcPais
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NrcPais>> PostNrcPais(NrcPais nrcPais)
        {
            _context.NrcPais.Add(nrcPais);
            try
            {

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NrcPaisExists(nrcPais.PaiCodigo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNrcPaisId", new { id = nrcPais.PaiCodigo}, nrcPais);
        }

        // PUT: api/NrcPais/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNrcPais(decimal id, NrcPais nrcPais)
        {
            if (id != nrcPais.PaiCodigo)
            {
                return BadRequest();
            }


            _context.Entry(nrcPais).State = EntityState.Modified;
            string path = Directory.GetCurrentDirectory();

            Log oLog = new Log(path);
            string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            oLog.Add(remoteIpAddress + " , " + "Actualizo Pais " + " , " + nrcPais.PaiCodigo);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NrcPaisExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();
            return CreatedAtAction(nameof(GetNrcPaisId), new { id = nrcPais.PaiCodigo}, nrcPais);
        }

        private bool NrcPaisExists(decimal id)
        {
            return _context.NrcPais.Any(e => e.PaiCodigo == id);
        }
    }
}
