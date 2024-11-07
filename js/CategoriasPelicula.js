// Selecciona todos los elementos de navegación
const navItems = document.querySelectorAll('.nav-item');

// Agrega eventos para cambiar el color cuando el ratón está encima
navItems.forEach(item => {
    item.addEventListener('mouseover', () => {
        item.style.color = '#0a0a0a'; // Oscurecer el color al pasar el ratón
    });
    item.addEventListener('mouseout', () => {
        item.style.color = '#0f1a34'; // Restaurar el color original al quitar el ratón
    });
});

