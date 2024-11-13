document.addEventListener("DOMContentLoaded", function () {
    const owlPelis = document.querySelector("#owl-pelis");

    if (!owlPelis) {
        console.error("No se encontró el elemento con ID #owl-pelis");
        return;
    }

    fetch("https://localhost:7056/CinemaParaiso/Pelicula")
        .then(response => {
            if (!response.ok) {
                throw new Error("Error al obtener las películas");
            }
            return response.json();
        })
        .then(peliculas => {
            peliculas.forEach(pelicula => {
                const itemDiv = document.createElement("div");
                itemDiv.classList.add("item");

                itemDiv.innerHTML = `
                    <div class="pelicula">
                        <img src="${pelicula.imagen}" alt="${pelicula.nombre}">
                        <h3>${pelicula.nombre}</h3>
                    </div>
                `;

                owlPelis.appendChild(itemDiv);
            });

            // Emitir evento personalizado cuando las películas están cargadas
            document.dispatchEvent(new Event("peliculasCargadas"));
        })
        .catch(error => {
            console.error("Error:", error);
            owlPelis.innerHTML = "<p>Error al cargar las películas</p>";
        });
});
