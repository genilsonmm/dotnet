using System.ComponentModel.DataAnnotations.Schema;

namespace app_books.Entity
{
    public class Book
    {
        public int BookId { get; set; }

        [Column(TypeName = "varchar(120)")]
        public required string Title { get; set; }
        public int Pages { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
