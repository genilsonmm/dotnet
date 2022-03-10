using SupplyControl.interfaces;

namespace SupplyControl.model
{
    public class Glue : SupplyBase, ISupply
    {
        public Glue(string code) : base(code)
        {
            
        }

        public string GetCode()
        {
            return "G" + base.code;
        }
    }
}
