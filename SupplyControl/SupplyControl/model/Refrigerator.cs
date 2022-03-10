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
        }

        public void CheckIn(ISupply supply)
        {

        }

        public void CheckOut(string code)
        {

        }

        public List<ISupply> GetAllSupplies()
        {
            return supplies;
        }
    }
}
