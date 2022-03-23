using SupplyControl.interfaces;
using SupplyControl.model;

namespace SupplyControl.infra
{
    public class Window
    {

        private Refrigerator refrigerator;

        public Window()
        {
            refrigerator = new Refrigerator(1010);
        }

        public void Start()
        {
            int option = 0;
            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                if (option == 0) break;


                DoAction(option);
                Console.ReadLine();

            } while (true);
           
        }

        private void DoAction(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    {
                        CheckIn();
                    }
                    break;
                case 2:
                    {
                        CheckOut();
                    }
                    break;
                case 3:
                    {
                        ShowAll();
                    }
                    break;
            }
        }

        private void CheckOut()
        {
            Console.WriteLine("---- Check-Out ----");
            ShowAll();
            Console.Write("Digite o código do insumo: ");
            string code = Console.ReadLine();
            ISupply supplyRemoved = refrigerator.CheckOut(code);

            if(supplyRemoved != null)
            {
                Console.WriteLine("Insumo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Insumo não encontrado!");
            }
        }

        private void ShowAll()
        {
            Console.WriteLine($"---- Listagem - Refrigerador { refrigerator.Id } ----");
            refrigerator.GetAllSupplies().ForEach(supply =>
                Console.WriteLine($"{ supply.GetCode()} - { supply.GetType().Name }"));
        }

        private void CheckIn()
        {
            Console.WriteLine("---- Check-Int ----");
            Console.Write("Digite o tipo de insumo (P - Para pasta de solda | C - Para Cola: ");
            string supplyType = Console.ReadLine();

            Console.Write("Digite o código do insumo: ");
            string supplyCode = Console.ReadLine();

            ISupply supply = null;

            if(supplyType.ToUpper().Equals("P"))
            {
                supply = new SolderPaste(supplyCode);
            } else if (supplyType.ToUpper().Equals("C"))
            {
                supply = new Glue(supplyCode);
            } else
            {
                Console.WriteLine("Tipo de insumo inválido!");
                Console.ReadLine();
                CheckIn();              
            }

            refrigerator.CheckIn(supply);
            Console.WriteLine("Check-In realizado com sucesso!");
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("### Gerenciamento de Insumos ###");
            Console.WriteLine("");
            Console.WriteLine("1. Realizar Check-In");
            Console.WriteLine("2. Realizar Check-Out");
            Console.WriteLine("3. Visualizar todos os insumos");
            Console.WriteLine("0. Sair");
        }
    }
}
