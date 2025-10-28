public class Pizza
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    private readonly List<Ingrediente> _ingredientes = new List<Ingrediente>();

    public IReadOnlyCollection<Ingrediente> Ingredientes => _ingredientes.AsReadOnly();

    public Pizza(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public void AgregarIngrediente(Ingrediente ingrediente)
    {
        _ingredientes.Add(ingrediente);
    }

    public decimal CalcularTotal()
    {
        return _ingredientes.Sum(p => p.Precio);
    }
}