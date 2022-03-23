using SupplyControl.interfaces;

namespace SupplyControl.model
{
    public class Refrigerator
    {
        private List<ISupply> supplies;

        public int Id { get; private set; }

        public Refrigerator(int id)
        {
            this.Id = id;
            this.supplies = new List<ISupply>();
        }

        public void CheckIn(ISupply supply)
        {
            this.supplies.Add(supply);
        }

        public ISupply CheckOut(string code)
        {
            ISupply? supply = this.supplies.Find(s => s.GetCode().Equals(code));
            this.supplies.Remove(supply);
            return supply;
        }

        public List<ISupply> GetAllSupplies()
        {
            return supplies;
        }
    }
}