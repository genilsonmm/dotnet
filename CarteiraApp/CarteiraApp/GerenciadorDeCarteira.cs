using CarteiraApp.BDMock;
using CarteiraApp.Modelo;

namespace CarteiraApp
{
    public class GerenciadorDeCarteira
    {
        public GerenciadorDeCarteira()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            int opcao = 0;
            do
            {
                ExibirMenu();
                opcao = int.Parse(Console.ReadLine());
                MenuDeOpcoes(opcao);
            } while (opcao != 0);
        }

        private void MenuDeOpcoes(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    {
                        CadastrarAtivo();
                        break;
                    }
                case 2:
                    {
                        ExibirAtivos();
                        break;
                    }
                case 3:
                    {      
                        PesquisarPorCodigo();
                        break;
                    }
                default:
                    break;
            }
        }

        private void ExibirAtivos()
        {
            List<string> codigos = AtivoRepository.Instance().ObterAtivos()
                 .GroupBy(x => x.Codigo)
                 .Select(ativo => ativo.First().Codigo)
                 .ToList();


            codigos.ForEach(item =>
            {
                Console.WriteLine(item);
                ExibirAtivoPorCodigo(item);
            });

            Console.ReadLine();
        }

        private void PesquisarPorCodigo()
        {
            ExibirTitulo();
            Console.WriteLine("##### Pesquisa por ativo #######");
            Console.WriteLine("Digite o código do ativo: ");

            string codigo = Console.ReadLine().ToUpper();

            try
            {
                ExibirAtivoPorCodigo(codigo);

                Console.WriteLine("1. Para editar");
                Console.WriteLine("2. Para remover");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    EditarAtivo();

                }
                else if (opcao == 2)
                {
                    RemoverTransacao();
                }
            } catch(Exception error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
            }
        }

        private static void EditarAtivo()
        {
            Console.Write("Digite o Id da transação para editar: ");
            string id = Console.ReadLine();
            string novoCodigo;
            int novaQuantidade;
            decimal novoPreco;
            DateTime novaData;
            ObterDadosDoAtivo(out novoCodigo, out novaQuantidade, out novoPreco, out novaData);

            Ativo ativoEditado = AtivoRepository.Instance().ObterAtivos().Find(item => item.Id.Equals(id));
            ativoEditado.Quantidade = novaQuantidade;
            ativoEditado.DataCompra = novaData;
            ativoEditado.Codigo = novoCodigo;
            ativoEditado.Preco = novoPreco;
        }

        private static void RemoverTransacao()
        {
            Console.Write("Digite o Id da transação para remover: ");
            string id = Console.ReadLine();

            Ativo ativo = AtivoRepository.Instance().ObterAtivos().Find(item => item.Id.Equals(id));
            AtivoRepository.Instance().ObterAtivos().Remove(ativo);
            Console.WriteLine("Transação removida com sucesso!");
            Console.ReadLine();
        }

        private static void ExibirAtivoPorCodigo(string codigo)
        {
            List<Ativo> ativos = AtivoRepository.Instance().ObterAtivos()
                .Where(ativo => ativo.Codigo.Equals(codigo)).ToList();

            if (ativos.Count == 0)
                throw new Exception("Ativo não encontrado!");

            ativos.ForEach(ativo => Console.WriteLine(ativo));
        }

        private void CadastrarAtivo()
        {
            ExibirTitulo();

            string codigo;
            int quantidade;
            decimal preco;
            DateTime data;
            ObterDadosDoAtivo(out codigo, out quantidade, out preco, out data);

            Ativo ativo = new Ativo(codigo, quantidade, preco, data);

            AtivoRepository.Instance().ObterAtivos().Add(ativo);
            Console.WriteLine("Ativo cadastrado com sucesso!");
            Console.ReadLine();
        }

        private static void ObterDadosDoAtivo(out string codigo, out int quantidade, out decimal preco, out DateTime data)
        {
            Console.Write("Digite o código do ativo: ");
            codigo = Console.ReadLine().ToUpper();
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço: ");
            preco = decimal.Parse(Console.ReadLine());
            Console.Write("Data da compra ex.: (dd/mm/yyyy): ");
            data = DateTime.Parse(Console.ReadLine());
        }

        private static void ExibirTitulo()
        {
            Console.Clear();
            Console.WriteLine("########## - Gerenciador de carteira de ativos - ##########");
        }

        private void ExibirMenu()
        {
            Console.Clear();

            Console.WriteLine("########## - Gerenciador de carteira de ativos - ##########");
            Console.WriteLine("1. Cadastrar transações");
            Console.WriteLine("2. Exibir ativos");
            Console.WriteLine("3. Consultar por código"); //Editar e remover
            Console.WriteLine("0. Sair");
        }
    }
}