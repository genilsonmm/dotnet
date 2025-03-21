using System.ComponentModel.DataAnnotations;

namespace app_books.Entity
{
    public class Book
    {
        public int BookId { get; set; }
        public required string Title { get; set; }
        public int Pages { get; set; }
    }
}
