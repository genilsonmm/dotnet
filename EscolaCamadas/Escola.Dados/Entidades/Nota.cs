using System.ComponentModel.DataAnnotations.Schema;

namespace Escola.Dados.Entidades
{
    public class Nota
    {
        public int NotaId { get; set; }

        public decimal Valor { get; set; }

        //[ForeignKey("AlunoId")]
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
