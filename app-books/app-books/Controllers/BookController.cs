using app_books.Data;
using app_books.Dto;
using app_books.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost]
        public ActionResult Create([FromBody] Book book)
        {
            book.Id = Guid.NewGuid();
            Database.Instance().AddBook(book);
            return Created(nameof(Create), book);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            List<BookResponse> bookResponse = new List<BookResponse>();
            var books = Database.Instance().GetBooks();

            books.ForEach(book =>
            {
                BookResponse br = new BookResponse();
                br.Id = book.Id;
                br.Title = book.Title;
                br.Author = GetAuhorById(book.AuthorId);

                bookResponse.Add(br);
            });

            return Ok(bookResponse);
        }

        private AuthorResponse GetAuhorById(Guid id)
        {
            Author author = Database.Instance().GetAuthors()
                .Where(a => a.Id.Equals(id)).FirstOrDefault();

            return new AuthorResponse() { Name = author.Name };
        }
  
    }
}
