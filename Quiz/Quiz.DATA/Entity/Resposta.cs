using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.DATA.Entity
{
    [Table("Respostas")]
    public class Resposta
    {
        public Resposta(string alternativaCorreta)
        {
            this.AlternativaCorreta = alternativaCorreta;
        }

        public int RespostaId { get; set; }

        [Column(TypeName = "varchar(1)")]
        [Required]
        public string AlternativaCorreta { get; set; }

        public int QuestaoId { get; set; }

        public Questao Questao { get; set; }
    }
}
