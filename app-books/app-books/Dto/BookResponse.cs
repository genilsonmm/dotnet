namespace app_books.Dto
{
    public class BookResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public AuthorResponse Author { get; set; }
    }
}
