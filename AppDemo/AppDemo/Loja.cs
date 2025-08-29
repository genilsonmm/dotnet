namespace AppDemo
{
    public class Loja
    {
        public void Iniciar()
        {
            ExibirMenu();
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    {
                        Cadastrar();
                    }
                    break;
                case 2:
                    {
                        Pesqusiar();
                    }
                    break;

                case 3:
                    {
                        Listar();
                    }
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        private void ExibirMenu()
        {
            Console.WriteLine("1. Cadastrar");
            Console.WriteLine("2. Pesquisar");
            Console.WriteLine("3. Listar");
        }

        void Listar()
        {

            Console.WriteLine("Listar");
        }

        private void Pesqusiar()
        {
            Console.WriteLine("Pesquisar");
        }

        void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("#### Cadastrar ####");
            Console.WriteLine("Digite seu nome: ");
        }
    }
}
