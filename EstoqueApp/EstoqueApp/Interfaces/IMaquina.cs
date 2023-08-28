namespace EstoqueApp.Interfaces
{
    public interface IMaquina
    {
        void CheckIn(Insumo insumo);
        void CheckOut(Guid id);
    }
}
