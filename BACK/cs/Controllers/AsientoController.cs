using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace CineApi.Controllers
{
    [ApiController]
    [Route("CinemaParaiso/[controller]")]
    public class AsientoController : ControllerBase
    {
        private static List<Asiento> Asientos = new List<Asiento>();

        [HttpGet]
        public ActionResult<IEnumerable<Asiento>> GetAll()
        {
            return Ok(Asientos);
        }

        [HttpGet("{idasiento}")]
        public ActionResult<Asiento> GetById(int idasiento)
        {
            var asiento = Asientos.FirstOrDefault(a => a.IdAsiento == idasiento);
            if (asiento == null)
                return NotFound();
            return Ok(asiento);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Asiento asiento)
        {
            Asientos.Add(asiento);
            return CreatedAtAction(nameof(GetById), new { idasiento = asiento.IdAsiento }, asiento);
        }

        [HttpPut("{idasiento}")]
        public ActionResult Update(int idasiento, [FromBody] Asiento updatedAsiento)
        {
            var asiento = Asientos.FirstOrDefault(a => a.IdAsiento == idasiento);
            if (asiento == null)
                return NotFound();

            asiento.Estado = updatedAsiento.Estado;
            return NoContent();
        }

        [HttpDelete("{idasiento}")]
        public ActionResult Delete(int idasiento)
        {
            var asiento = Asientos.FirstOrDefault(a => a.IdAsiento == idasiento);
            if (asiento == null)
                return NotFound();

            Asientos.Remove(asiento);
            return NoContent();
        }
    }
}
