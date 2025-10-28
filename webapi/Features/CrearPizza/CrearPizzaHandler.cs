public class CrearPizzaHandler : IRequestHandler<CrearPizzaCommand, int>
{
    private readonly IPizzaRepository _repository;

    public CrearPizzaHandler(IPizzaRepository repository)
    {
        _repository = repository;
    }

    public Task<int> Handle(CrearPizzaCommand request, CancellationToken cancellationToken)
    {
        var pizza = new Pizza(0, request.Cliente);

        foreach (var ingrediente in request.Ingredientes)
        {
            pizza.AgregarIngrediente(new Ingrediente(0, ingrediente, 100)); // Precio por defecto
        }

        _repository.Guardar(pizza);
        return Task.FromResult(pizza.Id);
    }
}