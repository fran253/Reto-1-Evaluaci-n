namespace Models;

public class Entrada {
    public int IdEntrada {get;set;}
    public decimal Precio {get;set;}
    //public string IdUsuario {get;set;}





    public Entrada(int identrada, decimal precio) {
        IdEntrada = identrada;
        Precio = precio;
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
