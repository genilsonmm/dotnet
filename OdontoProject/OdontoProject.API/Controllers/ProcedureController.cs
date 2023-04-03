using Microsoft.AspNetCore.Mvc;
using OdontoProject.API.Data;
using OdontoProject.API.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OdontoProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedureController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Database.procedures);
        }


        [HttpPost]
        public IActionResult Add([FromBody] Procedure procedure) 
        { 
            procedure.Id = Guid.NewGuid();
            Database.procedures.Add(procedure);
            return Ok();
        }
    }
}
