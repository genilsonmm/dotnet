using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.DATA.Entity
{
    [Table("Questoes")]
    public class Questao
    {
        public int QuestaoId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Titulo { get; set; }

        [Column(TypeName = "varchar(150)")]
        [Required]
        public string AlternativaA { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required]
        public string AlternativaB { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required]
        public string AlternativaC { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required]
        public string AlternativaD { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required]
        public string AlternativaE { get; set; }
    }
}