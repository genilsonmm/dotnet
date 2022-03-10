using SupplyControl.interfaces;

namespace SupplyControl.model
{
    public class SolderPaste : SupplyBase, ISupply
    {
        public SolderPaste(string code) : base(code)
        {

        }

        public string GetCode()
        {
            return "S" + base.code;
        }
    }
}
