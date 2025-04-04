using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_books.Entity
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public required string Name { get; set; }
    }
}
