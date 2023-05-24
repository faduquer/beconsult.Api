using Microsoft.AspNetCore.Mvc;
using beconsult.DataAccessLayer;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace beconsult.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichasController : ControllerBase
    {
        private IFichas fichas = new FichasRepository();

        // GET: api/<FichasController>
        [HttpGet]
        public ActionResult<IEnumerable<Ficha>> GetAllFichas()
        {
            return fichas.GetAllFichas();
        }

        // GET api/<FichasController>/5
        [HttpGet("{id}")]
        public ActionResult<Ficha> GetFicha(int id)
        {
            return fichas.GetFicha(id);
        }

        // POST api/<FichasController>
        [HttpPost]
        public ActionResult Post([FromBody] Ficha ficha)
        {
            //return StatusCode(StatusCodes.Status200OK, "Registro creado.");
            return StatusCode(StatusCodes.Status200OK, JsonSerializer.Serialize(ficha));
        }

        // PUT api/<FichasController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Ficha ficha)
        {
            return StatusCode(StatusCodes.Status200OK, JsonSerializer.Serialize(ficha));
        }

        // DELETE api/<FichasController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return StatusCode(StatusCodes.Status200OK, "Registro eliminado.");
        }
    }
}
