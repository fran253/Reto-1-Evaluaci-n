namespace Models;

public class Sala {
    public int IdSala {get;set;}
    public int IdAsiento {get;set;}





    public Sala(int idsala, int idasiento) {
        IdSala = idsala;
        IdAsiento = idasiento;
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
