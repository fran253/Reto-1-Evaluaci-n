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
            peliculas.Add(new Pelicula(1, "RED ONE", 148, "Nick Kroll, Dwayne Johnson, Chris Evans, Kristofer Hivju, Kiernan Shipka, Bonnie Hunt, Mary Elizabeth Ellis, Wesley Kimmel, Lucy Liu, J.K. Simmons",
            "+7", new DateTime(2024, 11, 6), new DateTime(2024, 11, 9, 18, 0, 0), 
            "Tras el secuestro de Papá Noel, nombre en clave: RED ONE, el Jefe de Seguridad del Polo Norte (Dwayne Johnson) debe formar equipo con el cazarrecompensas más infame del mundo (Chris Evans) en una misión trotamundos llena de acción para salvar la Navidad. No te pierdas #RedOne, protagonizada por Dwayne Johnson y Chris Evans. Disfruta de la película a partir del 6 noviembre solo en cines.",
            1, 5));      
            peliculas.Add(new Pelicula(2, "VENOM 3", 138, "Rhys Ifans, Chiwetel Ejiofor, Tom Hardy, Stephen Graham, Alanna Ubach, Juno Temple, Clark Backo, Peggy Lu",
            "+12", new DateTime(2024, 10, 25), new DateTime(2024, 11, 9, 20, 30, 0), 
            "Eddie y Venom están a la fuga. Perseguidos por sus sendos mundos y cada vez más cercados, el dúo se ve abocado a tomar una decisión devastadora que hará que caiga el telón sobre el último baile de Venom y Eddie.",
            2, 1));
            peliculas.Add(new Pelicula(3, "GLADIATOR II", 138, "Paul Mescal, Denzel Washington, Connie Nielsen, Joseph Quinn, Derek Jacobi, Fred Hechinger, Lior Raz, Pedro Pascal",
            "+16", new DateTime(2024, 11, 15), new DateTime(2024, 11, 9, 20, 30, 0), 
            "Años después de presenciar la muerte del admirado héroe Máximo a manos de su tío, Lucio (Paul Mescal) se ve forzado a entrar en el Coliseo tras ser testigo de la conquista de su hogar por parte de los tiránicos emperadores que dirigen Roma con puño de hierro. Con un corazón desbordante de furia y el futuro del imperio en juego, Lucio debe rememorar su pasado en busca de la fuerza y el honor que devuelvan al pueblo la gloria perdida de Roma.",
            3, 4));
        }



    }
}
