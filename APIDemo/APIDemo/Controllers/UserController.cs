using APIDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly List<User> users = new List<User>();

        public UserController()
        {
            users.Add(new User() { Id = 1, Name = "Maria", CPF = "123" });
            users.Add(new User() { Id = 2, Name = "Daniela", CPF = "675" });
            users.Add(new User() { Id = 3, Name = "Maria", CPF = "497" });
        }

        //localhost:62434/api/user
        [HttpGet]
        public string Get()
        {
            return "Olá WebAPI";
        }

        [HttpGet("all")]
        public List<User> GetAll()
        {
            return users;
        }

        [HttpGet("test/{id}")]
        public IActionResult Test(string id)
        {
            return Ok(id);
        } 
    }
}
