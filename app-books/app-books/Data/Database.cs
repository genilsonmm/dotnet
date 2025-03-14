using app_books.Entity;

namespace app_books.Data
{
    public class Database
    {
        private static Database instance;
        private List<Book> books = new List<Book>();
        private List<Author> authors = new List<Author>();

        public static Database Instance()
        {
            if (instance == null)
                instance = new Database();

            return instance;
        }

        public void AddBook(Book book) => books.Add(book);

        public void AddAuthor(Author author) => authors.Add(author);    


        public List<Book> GetBooks() => books;

        public List<Author> GetAuthors() => authors;
    }
}
