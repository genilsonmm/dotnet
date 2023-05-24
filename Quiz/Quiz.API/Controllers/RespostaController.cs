using Microsoft.AspNetCore.Mvc;
using Quiz.DATA.Data;
using Quiz.DATA.Entity;
using Quiz.DATA.Repository;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespostaController : ControllerBase
    {
        private readonly RespostaRepository _respostaRepository;

        public RespostaController(RespostaRepository respostaRepository) => _respostaRepository = respostaRepository;

        [HttpPost]
        public IActionResult Post([FromBody] Resposta resposta)
        {
            return Ok(_respostaRepository.Insert(resposta));
        }
    }
}
