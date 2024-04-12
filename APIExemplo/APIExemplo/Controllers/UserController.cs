using APIExemplo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Ping() => "pong";

        [HttpGet("list")]
        public User GetUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                Name = "Maria da Silva",
                Age = 30
            };
        }

        [HttpPost]
        public ActionResult Register([FromBody] User user)
        {
            //return NotFound();
            //return Unauthorized();
            //return NoContent();
            //Cadastrar user
            return Created(
                "http://localhost:5278/api/user/list", 
                user);
        }
    }
}
