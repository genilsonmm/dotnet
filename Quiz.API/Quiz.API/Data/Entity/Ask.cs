using System.ComponentModel.DataAnnotations;

namespace Quiz.API.Data.Entity
{
    public class Ask
    {
        public int AskId { get; set; }
        public String? Title { get; set; }
    }
}
