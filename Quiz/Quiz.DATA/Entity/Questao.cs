using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.DATA.Entity
{
    public class Questao
    {
        public int QuestaoId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(100)]
        [Column(TypeName = "varchar(60)")]
        public string Title { get; set; }
        public Alternativa Alternativa { get; set; }
    }
}
