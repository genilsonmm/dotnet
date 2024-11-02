using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.API.Data.Entity
{
    public class Ask
    {
        public int AskId { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public String? Title { get; set; }

        public List<Answer>? Answers { get; set; } = new List<Answer>();
    }
}
