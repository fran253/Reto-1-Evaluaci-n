document.addEventListener("DOMContentLoaded", function() {
    const seatsContainer = document.querySelector(".seats-container");
    const rows = 10;
    const columns = 10;

    // Generar la cuadrícula de asientos
    for (let row = 0; row < rows; row++) {
        for (let col = 0; col < columns; col++) {
            const seat = document.createElement("div");
            seat.classList.add("seat-item");

            // Simular algunos asientos ocupados
            if (Math.random() > 0.8) {
                seat.classList.add("occupied");
            }

            // Añadir evento para seleccionar/deseleccionar el asiento
            seat.addEventListener("click", function() {
                // Verificar si el asiento está ocupado
                if (!seat.classList.contains("occupied")) {
                    seat.classList.toggle("selected");
                }
            });

            seatsContainer.appendChild(seat);
        }
    }
});
