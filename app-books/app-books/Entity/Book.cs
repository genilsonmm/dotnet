namespace app_books.Entity
{
    public class Book
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public int Pages { get; set; }
        public Guid AuthorId { get; set; } 
    }
}
