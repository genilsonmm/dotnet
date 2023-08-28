using EstoqueApp.Interfaces;

namespace EstoqueApp.Model
{
    public class Cola : Insumo
    {
        private decimal taxa = 2 / 100;
        private Guid id;

        public Cola()
        {
            this.id = Guid.NewGuid();
        }

        public Guid GetId() => this.id;


        public decimal Imposto()
        {
            throw new NotImplementedException();
        }
    }
}
