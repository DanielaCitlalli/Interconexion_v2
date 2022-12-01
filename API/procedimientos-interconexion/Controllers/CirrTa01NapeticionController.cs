using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using procedimientos_interconexion.Models;

namespace procedimientos_interconexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CirrTa01NapeticionController : ControllerBase
    {
        private readonly InterconexionContext _context;

        public CirrTa01NapeticionController(InterconexionContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
            
        }

        public IConfiguration Configuration { get; }

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

        // GET: api/CirrTa01Napeticion/5
        [HttpGet]
        [Route("buscarcadena/{crip}")]
        public async Task<ActionResult<List<NrcNacimientos>>> buscarCadena(string crip)
        {
            try
            {
                //Los indices comienzan en 0 a diferencia de script en SQL
                var res = await (from _Nacimientos in _context.NrcNacimientos
                                 where crip == _Nacimientos.Cadena.Substring(1, 2) + _Nacimientos.Cadena.Substring(3, 3) +
                                 _Nacimientos.Cadena.Substring(8, 2) + _Nacimientos.Cadena.Substring(12, 2) +
                                 _Nacimientos.Cadena.Substring(14, 5)
                                 select new
                                 {
                                     _Nacimientos.Cadena,
                                     _Nacimientos.PeNombres,
                                     _Nacimientos.PePrimerapellido,
                                     _Nacimientos.PeSegundoapellido,
                                     _Nacimientos.PeCurp,
                                     _Nacimientos.OtErrororigen
                                 }).ToListAsync();

                //var res = _context.NrcNacimientos.FromSqlInterpolated($@"EXEC dbo.cripToCadenaNac @crip={crip}").AsAsyncEnumerable();


                return Ok(res);

            }
            catch (Exception ex)
            {
                return BadRequest();
            }


            //--Solucion alternativa
            #region
            //var conectionString = Configuration.GetConnectionString("DbConnection");
            //SqlConnection cnn;

            //cnn = new SqlConnection(conectionString);

            //SqlCommand Comm;
            //SqlDataReader reader;

            //List<NacimientosCadenas> milista;
            //milista = new List<NacimientosCadenas>();

            //NacimientosCadenas registro;


            //try
            //{
            //    cnn.Open();
            //    Comm = cnn.CreateCommand();
            //    Comm.CommandText = "dbo.cripToCadenaNac2";
            //    Comm.CommandType = CommandType.StoredProcedure;
            //    Comm.Parameters.Add("@crip", SqlDbType.VarChar, 14).Value = crip;
            //    Comm.CommandTimeout = 3600;
            //    reader = await Comm.ExecuteReaderAsync();
            //    while (reader.Read())
            //    {
            //        registro = new NacimientosCadenas();
            //        registro.Cadena = reader["CADENA"].ToString();
            //        registro.PeNombres = reader["PE_NOMBRES"].ToString();
            //        registro.PePrimerapellido = reader["PE_PRIMERAPELLIDO"].ToString();
            //        registro.PeSegundoapellido = reader["PE_SEGUNDOAPELLIDO"].ToString();
            //        registro.PeCurp = reader["PE_CURP"].ToString();
            //        registro.OtErrororigen = reader["OT_ERRORORIGEN"].ToString();
            //        milista.Add(registro);
            //    }

            //    reader.Close();
            //    Comm.Dispose();
            //    cnn.Close();
            //    cnn.Dispose();
            //    return Ok(milista);
            //    //return Ok("conexion abierta");
            //}
            //catch (SqlException ex)
            //{
            //    cnn.Close();
            //    cnn.Dispose();
            //    return BadRequest();
            //}
            #endregion


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

            // BORRAR NACIMIENTOS

            try
            {

                _context.Add(cirrTa01Napeticion);
                    
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress=HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " , " + "Se borro Nacimiento" + " , " + cirrTa01Napeticion.Ta01CCadena);


                return CreatedAtAction(nameof(GetCirrTa01NapeticionId), new { id = cirrTa01Napeticion.Ta01EOid }, cirrTa01Napeticion);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

         }

        [HttpPost]
        [Route("ForzarSubirActaNacimientos")]
        public async Task<ActionResult<CirrTa01Napeticion>> PostCirrTa01Napeticion02(CirrTa01Napeticion cirrTa01Napeticion)
        {
            try
            {
                _context.CirrTa01Napeticion.Add(cirrTa01Napeticion);
                await _context.SaveChangesAsync();
                string path = Directory.GetCurrentDirectory();

                Log oLog = new Log(path);
                string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
                oLog.Add(remoteIpAddress + " , " + "Se subio Acta de nacimiento " + " , " + cirrTa01Napeticion.Ta01CCadena);


                return CreatedAtAction(nameof(GetCirrTa01NapeticionId), new { id = cirrTa01Napeticion.Ta01EOid }, cirrTa01Napeticion);
            }
            catch(Exception ex){
                return BadRequest();
            }

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
