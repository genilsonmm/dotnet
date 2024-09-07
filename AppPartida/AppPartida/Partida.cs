namespace AppPartida
{
    public class Partida
    {
        public int Id { get;}
        public Time Time1 { get; }
        public Time Time2 { get; }

        public int GolTime1 { get; set; } = 0;
        public int GolTime2 { get; set; } = 0;

        public Partida(Time time1, Time time2, int id)
        {
            this.Id = id;
            this.Time1 = time1;
            this.Time2 = time2;
        }

        public override string ToString()
        {
            return $"{Id} | {Time1.Nome} {GolTime1} x {GolTime2} {Time2.Nome}";
        }
    }
}
