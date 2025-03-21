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
        private readonly DataContext _dataContext;

        public BookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpPost]
        public ActionResult Create([FromBody] Book book)
        {
            _dataContext.Books.Add(book);
            _dataContext.SaveChanges();
            return Created(nameof(Create), book);
        }

        [HttpGet]
        public ActionResult GetAll()
        {  
            return Ok(_dataContext.Books.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult GetAll(int id)
        {
            return Ok(_dataContext.Books
                .Where(l=>l.BookId == id).FirstOrDefault());
        }

        private AuthorResponse GetAuhorById(int id)
        {
            Author author = Database.Instance().GetAuthors()
                .Where(a => a.AuthorId == id).FirstOrDefault();

            return new AuthorResponse() { Name = author.Name };
        }
  
    }
}
