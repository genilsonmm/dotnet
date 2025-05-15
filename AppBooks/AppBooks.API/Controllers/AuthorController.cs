using AppBooks.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppBooks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AuthorController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public ActionResult Create([FromBody] Author author)
        {
            _dataContext.Authors.Add(author);
            _dataContext.SaveChanges();
            return Ok(author);
        }
    }
}
