namespace AppPartida
{
    public class Campeonato
    {
        private readonly List<Partida> partidas;

        public Campeonato()
        {
            partidas = new List<Partida>();
            CriarTabela();
            VerTabela();
        }

        
        private void CriarTabela()
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

        private void VerTabela() => partidas.ForEach(partida => Console.WriteLine(partida));

        public void Placar(int partidaId, int placar1, int placar2)
        {
            Partida partida = partidas.Find(p => p.Id == partidaId);
            Console.WriteLine(partida);
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
