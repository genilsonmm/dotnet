using Microsoft.AspNetCore.Mvc;
using Quiz.DATA.DTO;
using Quiz.DATA.Service;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestaoController : ControllerBase
    {
        private readonly QuestaoService _questaoService;

        public QuestaoController(QuestaoService questaoService)
        {
            _questaoService = questaoService;
        }

        [HttpGet]
        public ActionResult<List<QuestaoDTO>> Get() => _questaoService.GetAll();

        [HttpPost]
        public ActionResult Post([FromBody] NovaQuestaoDTO novaQuestao)
        {
            return Created("", _questaoService.Insert(novaQuestao));
        }
    }
}
