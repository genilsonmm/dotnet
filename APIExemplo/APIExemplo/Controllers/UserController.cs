using APIExemplo.Database;
using APIExemplo.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpGet]
        public string Ping() => "pong";

        [HttpGet("list")]
        public ActionResult GetUser()
        {
            return Ok(Context.Instance().GetAll()); 
        }

        [HttpGet("{id}")]
        public ActionResult GetOne(Guid id) => 
            Ok(Context.Instance().GetAll().Find(u => u.Id == id));

        [HttpPost]
        public ActionResult Register([FromBody] User user)
        {
            //return NotFound();
            //return Unauthorized();
            //return NoContent();
            //Cadastrar user

            user.Id = Guid.NewGuid();
            Context.Instance().AddUser(user);

            return Created(
                "http://localhost:5278/api/user/list", 
                user);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            Context.Instance().GetAll().Remove(
                Context.Instance().GetAll().Find(u => u.Id.Equals(id)));

            return Ok("Usuário removido");
        }

        [HttpPut("{id}")]
        public ActionResult PutUser([FromBody] UserRequest user, Guid id) 
        {
            var userToEdit = Context.Instance().GetAll().Find(u => u.Id.Equals(id));
            userToEdit.Name = user.Name;
            userToEdit.Age = user.Age;

            return Ok(userToEdit);
        }
    }
}
