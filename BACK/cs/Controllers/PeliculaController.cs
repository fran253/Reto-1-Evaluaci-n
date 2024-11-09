using Microsoft.AspNetCore.Mvc;

using Models;

namespace CineApi.Controllers
{
    [ApiController]
    [Route("CinemaParaiso/[controller]")]
    public class PeliculaController : ControllerBase
    {
        private static List<Pelicula> peliculas = new List<Pelicula>();

        [HttpGet]
        public ActionResult<IEnumerable<Pelicula>> GetAll()
        {
            return Ok(peliculas);
        }

        [HttpGet("{id}")]
        public ActionResult<Pelicula> GetById(int id)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.IdPelicula == id);
            if (pelicula == null)
                return NotFound();
            return Ok(pelicula);
        }

        [HttpPost]
        public ActionResult<Pelicula> Create([FromBody] Pelicula pelicula)
        {
            peliculas.Add(pelicula);
            return CreatedAtAction(nameof(GetById), new { id = pelicula.IdPelicula }, pelicula);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Pelicula updatedPelicula)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.IdPelicula == id);
            if (pelicula == null)
                return NotFound();

            pelicula.Nombre = updatedPelicula.Nombre;
            pelicula.Duracion = updatedPelicula.Duracion;
            pelicula.Actores = updatedPelicula.Actores;
            pelicula.EdadMinima = updatedPelicula.EdadMinima;
            pelicula.FechaEstreno = updatedPelicula.FechaEstreno;
            pelicula.Horario = updatedPelicula.Horario;
            pelicula.Descripcion = updatedPelicula.Descripcion;
            pelicula.IdEntrada = updatedPelicula.IdEntrada;
            pelicula.IdSala = updatedPelicula.IdSala;
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.IdPelicula == id);
            if (pelicula == null)
                return NotFound();

            peliculas.Remove(pelicula);
            return NoContent();
        }

        public static void InicializarDatos()
        {
            peliculas.Add(new Pelicula(1, "Inception", 148, "Leonardo DiCaprio, Joseph Gordon-Levitt", "13", new DateTime(2010, 7, 16), new DateTime(2023, 11, 9, 18, 0, 0), 
            "A thief who steals corporate secrets through the use of dream-sharing technology.", 1, 3));          
            peliculas.Add(new Pelicula(2, "The Matrix", 136, "Keanu Reeves, Laurence Fishburne", "16", new DateTime(1999, 3, 31), new DateTime(2023, 11, 9, 20, 30, 0), 
            "A hacker learns about the true nature of his reality and his role in the war against its controllers.", 2, 4));
        }



    }
}
