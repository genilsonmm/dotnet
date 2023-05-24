namespace Quiz.DATA.Entity
{
    public class Resposta
    {
        public int RespostaId { get; set; }
        public int QuestaoId { get; set; }
        public string Correta { get; set; }
    }
}
