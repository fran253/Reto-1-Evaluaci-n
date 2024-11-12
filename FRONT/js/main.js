document.addEventListener("DOMContentLoaded", function () {
    const peliculasContainer = document.querySelector(".peliculas");

    fetch("https://localhost:7056/CinemaParaiso/Pelicula")
        .then(response => {
            if (!response.ok) {
                throw new Error("Error al obtener las películas");
            }
            return response.json();
        })
        .then(peliculas => {
            peliculas.forEach(pelicula => {
                const peliculaDiv = document.createElement("div");
                peliculaDiv.classList.add("pelicula");

                peliculaDiv.innerHTML = `
                <div class="pelicula">
                    <img src="${pelicula.imagen}" alt="${pelicula.nombre}">
                    <h3>${pelicula.nombre}</h3>
                </div>
                `;

                peliculasContainer.appendChild(peliculaDiv);
            });
        })
        .catch(error => {
            console.error("Error:", error);
            peliculasContainer.innerHTML = "<p>Error al cargar las películas</p>";
        });
});

