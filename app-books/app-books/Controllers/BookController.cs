using app_books.Data;
using app_books.Dto;
using app_books.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return Ok(_dataContext.Books.Include(a =>a.Author).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult GetAll(int id)
        {
            return Ok(_dataContext.Books
                .Where(l=>l.BookId == id).FirstOrDefault());
        }  
    }
}
