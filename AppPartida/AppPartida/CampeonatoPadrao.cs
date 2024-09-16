namespace AppPartida
{
    public class CampeonatoPadrao : Campeonato, ICampeonato
    {
        private readonly List<Partida> partidas;

        public CampeonatoPadrao()
        {
            partidas = new List<Partida>();
            CriarTabela();
        }
    
        public void CriarTabela()
        {
            Partida p1 = new Partida(new Time("A"), new Time("B"), 1);
            Partida p2 = new Partida(new Time("C"), new Time("D"), 2);
            Partida p3 = new Partida(new Time("A"), new Time("C"), 3);
            Partida p4 = new Partida(new Time("B"), new Time("D"), 4);
            Partida p5 = new Partida(new Time("A"), new Time("D"), 5);
            Partida p6 = new Partida(new Time("B"), new Time("C"), 6);

            partidas.Add(p1);
            partidas.Add(p2);
            partidas.Add(p3);
            partidas.Add(p4);
            partidas.Add(p5);
            partidas.Add(p6);
        }

        public void VerTabela() => partidas.ForEach(partida =>
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine(partida);
        });

        public void Placar(int partidaId, int golTime1, int golTime2)
        {
            Partida? partida = partidas.Find(p => p.Id == partidaId);
            
            if (partida == null) throw new Exception();
            
            partida.GolTime1 = golTime1;
            partida.GolTime2 = golTime2;
        }

        public Finais ObterFinais()
        {
            Dictionary<string, int> pontuacao = new Dictionary<string, int>();
            pontuacao.Add("A", 0);
            pontuacao.Add("B", 0);
            pontuacao.Add("C", 0);
            pontuacao.Add("D", 0);

            partidas.ForEach((p) =>
            {
                if(p.GolTime1 > p.GolTime2) 
                {
                    pontuacao[p.Time1.Nome]++;
                } else
                {
                    pontuacao[p.Time2.Nome]++;
                }
            });

            List<KeyValuePair<string, int>> ordenado = 
                pontuacao.OrderByDescending(t=> t.Value).ToList();
            
            Time time1Final = new Time(ordenado[0].Key);
            Time time2Final = new Time(ordenado[1].Key);

            Time time3Final = new Time(ordenado[2].Key);
            Time time4Final = new Time(ordenado[3].Key);

            return new Finais()
            {
                Final = new Partida(time1Final, time2Final, 8),
                TerceiroLugar = new Partida(time3Final, time4Final, 7),
            };
        }


        /*
        private void VerTabela()
        {
            /*
            for(int i = 0; i < partidas.Count; i++)
            {
                //string time1 = partidas[i].Time1.Nome;
                //string time2 = partidas[i].Time2.Nome;
                //Console.WriteLine($"{partidas[i].Id} | {time1} x {time2}");
                //Console.WriteLine(partidas[i]);
            }
            */

        /*
        foreach (Partida partida in partidas)
        {
            Console.WriteLine(partida);
        }*/

        //partidas.ForEach(partida => Console.WriteLine(partida));
        /*
    }
        */
    }
}
