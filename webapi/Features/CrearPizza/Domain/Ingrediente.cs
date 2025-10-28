public class Ingrediente
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public decimal Precio { get; private set; }

    public Ingrediente(int id, string nombre, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }
}