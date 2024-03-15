
namespace Agendamento.Page
{
    public class PageManager
    {
        public PageManager()
        {
            Menu();
        }

        private void Menu()
        {
            Console.WriteLine("----- Bem vindo ao XPTO Agendamento");
            Console.WriteLine("1. Cadastrar Cliente");
            Console.WriteLine("2. Pesquisar Cliente");
            Console.WriteLine("3. Agendar");
            Console.WriteLine("0. Sair");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao) {
                case 1:
                    {
                        CadastrarCliente();
                    }
                    break;
                case 2:
                    {
                        PesquisarCliente();
                    }
                    break;
                case 3:
                    {
                        Agendar();
                    }
                break;
                case 0:
                    {
                        //Sair
                    }
                    break;
            }
        }

        private void Agendar()
        {
            throw new NotImplementedException();
        }

        private void PesquisarCliente()
        {
            throw new NotImplementedException();
        }

        private void CadastrarCliente()
        {
            Console.Clear();
            Console.WriteLine("---- Cadastro de Cliente ----");

        }
    }
}
