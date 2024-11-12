using CineApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Configurar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirOrigenLocal", policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500") // Permitir el acceso desde tu frontend
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Agregar servicios al contenedor
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuración de CORS en el pipeline de la aplicación
app.UseCors("PermitirOrigenLocal");

// Configuración del pipeline de peticiones HTTP
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

PeliculaController.InicializarDatos();
app.Run();
