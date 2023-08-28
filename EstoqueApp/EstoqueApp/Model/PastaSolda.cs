using EstoqueApp.Interfaces;

namespace EstoqueApp.Model
{
    public class PastaSolda : Insumo
    {
        private decimal taxa = 5 / 100;
        private Guid id;

        public PastaSolda()
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
