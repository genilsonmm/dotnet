
using Agendamento.Data;
using Agendamento.Model;

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
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("----- Bem vindo ao XPTO Agendamento");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Pesquisar Cliente");
                Console.WriteLine("3. Agendar");
                Console.WriteLine("0. Sair");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
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
                            opcao = -1;
                        }
                        break;
                }
            }while (opcao != -1);
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
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Id = Guid.NewGuid();

            Database.clientes.Add(cliente);
        }
    }

}
