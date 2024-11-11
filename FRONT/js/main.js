// FETCH CON LA API DE JSON DE LA BASE DE DATOS
async function fetchPeliculas() {
    const url = 'http://localhost:5199/CinemaParaiso/Pelicula';

    try {
        const response = await fetch(url);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const peliculas = await response.json();
        console.log('peliculas fetched:', peliculas);
        peliculas.forEach(createPelicula);
    } catch (error) {
        console.error('Error fetching peliculas:', error);
    }
}

function createPelicula(pelicula) {
    const peliculasList = document.querySelector('.peliculas');
    if (!peliculasList) {
        console.error('.peliculas no encontrado');
        return;
    }

    const card = document.createElement('div');
    card.classList.add('card');

    const { imagen, nombre } = pelicula;

    card.innerHTML = `
        <div class="pelicula">
            <img src="${imagen}" alt="${nombre}">
            <h3>${nombre}</h3>
        </div>
    `;

    peliculasList.appendChild(card);
}

document.addEventListener('DOMContentLoaded', fetchPeliculas);

////////////////////////////////////////////////////////////////////////////////////////////////////////////




