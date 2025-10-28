public class CrearPizzaCommand : IRequest<int>
{
    public string Nombre { get; set; }
    public List<string> Ingredientes { get; set; }
}