using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.API.Data;
using Quiz.API.Data.Entity;
using Quiz.API.Data.Repository;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AskController : ControllerBase
    {
        private readonly AskRepository _skRepository;

        public AskController(AskRepository skRepository) 
        {
            _skRepository = skRepository;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Ask ask)
            => Ok(_skRepository.Insert(ask));
        

        [HttpGet]
        public ActionResult Get() => Ok(_skRepository.GetAll());

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _skRepository.Delete(id);
            return Ok();
        }
    }
}
