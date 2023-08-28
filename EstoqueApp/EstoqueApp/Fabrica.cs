using EstoqueApp.Interfaces;
using EstoqueApp.Model;

namespace EstoqueApp
{
    public class Fabrica
    {
        private List<Insumo> insumos;
        private IMaquina maquina;

        public Fabrica()
        {
            this.insumos = new List<Insumo>();
            this.maquina = new Refrigerador();
            Inicializar();
        }

        private void Inicializar()
        {
            int opcao = 0;
            do
            {
                ExibirMenu();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            //Registrar
                            RegistrarInsumo();
                        }
                        break;
                    case 2:
                        {
                            //CheckIn
                            CheckIn();
                        }
                        break;
                    case 3:
                        {
                            //CheckOut
                        }
                        break;
                    case 4:
                        {
                            //Sair
                        }
                        break;
                }
            } while (opcao != 4);
        }

        private void CheckIn()
        {
            Console.Clear();
            Console.WriteLine("#########- CheckIn -#########");


            this.insumos.ForEach(item =>
            {
                int index = insumos.IndexOf(item);
                Console.WriteLine($"({index}) - Tipo: {item.GetType().Name} | Id: {item.GetId()}");
            });
            Console.Write("Digite o indice do insumo: ");
            int index = int.Parse(Console.ReadLine());


            Insumo insumo = this.insumos[index];
            this.maquina.CheckIn(insumo);
            Console.Write("CheckIn realizado com sucesso!");
            Console.ReadLine();
        }

        private static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindos a nossa Fábrica");
            Console.WriteLine("1- Registrar insumo");
            Console.WriteLine("2- CheckIn");
            Console.WriteLine("3- CheckOut");
            Console.WriteLine("4- Sair");
        }

        private void RegistrarInsumo()
        {
            Console.Clear();
            Console.WriteLine("#########- Registro de insumo -#########");
            Console.WriteLine("1- Cola");
            Console.WriteLine("2- Pasta de solda");

            int opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                this.insumos.Add(new Cola());
            } else
            {
                this.insumos.Add(new PastaSolda());
            }

            Console.WriteLine("Insumo adicionado com sucesso!");
            Console.ReadLine();
        }
    }
}
