namespace AppPartida
{
    public class GerenciadorDeCampeonato
    {
        private readonly Campeonato campeonato;

        public GerenciadorDeCampeonato()
        {
            campeonato = new Campeonato();
            Menu();
        }

        private void Menu()
        {
            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("------------- Campeonato XPTO -------------");
                Console.WriteLine("1. Adicionar placar");
                Console.WriteLine("2. Gerar finais");
                Console.WriteLine("3. Sair");
                
                opcao = int.Parse(Console.ReadLine());
                campeonato.VerTabela();

                switch (opcao)
                {
                    case 1:
                        {
                            AtualizarPartida();
                            break;
                        }
                    case 2:
                        {
                            GerarFinais();
                            break;
                        }

                    case 3:
                        {
                            break;
                        }
                }

                Console.ReadLine();
            }
        }

        private void GerarFinais()
        {
            Finais finais = campeonato.ObterFinais();
            Console.WriteLine("Final: ");
            Console.WriteLine(finais.Final);

            Console.WriteLine("Terceiro Lugar: ");
            Console.WriteLine(finais.TerceiroLugar);
        }

        private void AtualizarPartida()
        {
            Console.Write("Digite o id da partida: ");
            int idPartidada = int.Parse(Console.ReadLine());

            Console.Write("Placar (esquerda): ");
            int gol1 = int.Parse(Console.ReadLine());

            Console.Write("Placar (direita): ");
            int gol2 = int.Parse(Console.ReadLine());

            campeonato.Placar(idPartidada, gol1, gol2);
        }
    }
}
