namespace Escola.Dados.Entidades
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<decimal> Notas { get; set; }

        public Aluno() 
        {
            Id = Guid.NewGuid();    
            Notas = new List<decimal>();
        }
    }
}
