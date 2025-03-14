using app_books.Data;
using app_books.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpPost]
        public ActionResult Create([FromBody] Author author)
        {
            author.Id = Guid.NewGuid();
            Database.Instance().AddAuthor(author);
            return Created(nameof(Create), author);
        }

        [HttpGet]
        public ActionResult GetAll() => Ok(Database.Instance().GetAuthors());
    }
}
