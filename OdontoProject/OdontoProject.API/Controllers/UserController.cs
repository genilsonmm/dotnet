using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdontoProject.API.Data;
using OdontoProject.API.Entity;

namespace OdontoProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromBody] User user)
        {
            user.Id = Guid.NewGuid();
            Database.users.Add(user);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Database.users);
        }

        [HttpGet("{cpf}")]
        public IActionResult GetByCpf(string cpf)
        {
            if (cpf == null) return NotFound();

            var user = Database.users.Where(user => user.Cpf.Equals(cpf)).FirstOrDefault();
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id == null) return NotFound();
            User? user = GetUser(id);

            if (user == null) return NotFound();

            Database.users.Remove(user);

            return Ok("usuário removido com sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id, [FromBody] User user)
        {
            var editUser = GetUser(id);
            if(editUser == null) return NoContent();

            editUser.Cpf = user.Cpf;
            editUser.Name = user.Name;

            return Ok(editUser);
        }

        private User? GetUser(string id)
        {
            return Database.users.Where(user => user.Id.ToString().Equals(id)).FirstOrDefault();
        }
    }
}
