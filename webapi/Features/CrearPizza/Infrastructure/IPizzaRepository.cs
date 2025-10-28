public interface IPizzaRepository
{
    void Guardar(Pizza pizza);
    Pizza ObtenerPorId(int id);
}