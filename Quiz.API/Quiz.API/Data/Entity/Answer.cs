using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.API.Data.Entity
{
    public class Answer
    {
        public int AnswerId { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? ValueA { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string? ValueB { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string? ValueC { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string? ValueD { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string? ValueE { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string? AnswerValue { get; set; }

        public int AskId { get; set; }
        public Ask? Ask { get; set; }
    }
}
