public class PizzaRepository : IPizzaRepository
{
    private readonly List<Pizza> _pizzas = new List<Pizza>();

    public void Guardar(Pizza pizza)
    {
        _pizzas.Add(pizza);
    }

    public Pizza ObtenerPorId(int id)
    {
        return _pizzas.FirstOrDefault(p => p.Id == id);
    }
}