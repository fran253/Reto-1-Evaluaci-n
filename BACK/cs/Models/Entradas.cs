namespace Models;

public class Entrada {
    public int IdEntrada {get;set;}
    public decimal Precio {get;set;}
    //public string IdUsuario {get;set;}
    public DateOnly Horario {get;set;}
    //public int IdPelicula {get;set;}
    





    public Entrada(int identrada, decimal precio, DateOnly horario) {
        IdEntrada = identrada;
        Precio = precio;
        Horario = horario;
        // if (string.IsNullOrEmpty(nombre))
        // {
        //     throw new ArgumentException("Error: El nombre no puede estar vacío.");
        // }
        // if (precio < 0)
        // {
        //     throw new ArgumentException("Error: El precio no puede ser negativo.");
        // }
    }

    //public abstract void MostrarDetalles();

}
