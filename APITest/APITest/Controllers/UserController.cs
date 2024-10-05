using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Olá API";
        }

        [HttpGet("obter-usuario")]
        public User ObterUsuario()
        {
            return new User { Id = 1, Name = "Fulano" };  
        }

        [HttpGet("get-user")]
        public ActionResult GetUser()
        {
            return Ok(new User { Id = 1, Name = "Fulano" });
        }

        [HttpGet("{valor}/{valor2}")]
        public int Calcular(int valor, int valor2)
        {
            return valor * 2;
        }

        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            return Ok(user);
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] User user, int id)
        {
            user.Id = id;
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok($"Usuário ({id}) removido com sucesso!");
        }
    }
}
