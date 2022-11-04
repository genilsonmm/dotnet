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
        private readonly RespostasService _respostaService;

        public QuestaoController(QuestaoService questaoService, RespostasService respostasService)
        {
            _questaoService = questaoService;
            _respostaService = respostasService;
        }

        [HttpGet]
        public ActionResult<List<QuestaoDTO>> Get() => _questaoService.GetAll();

        [HttpPost("calcular")]
        public ActionResult CalcularRespostas([FromBody] List<RespostasDTO> respostas)
        {
            ResultadoDTO resultado = _respostaService.Calcular(respostas);
            return Ok(resultado);
        }

        [HttpPost]
        public ActionResult Post([FromBody] NovaQuestaoDTO novaQuestao)
        {
            return Created("", _questaoService.Insert(novaQuestao));
        }

        [HttpPut]
        public ActionResult Put([FromBody] NovaQuestaoDTO novaQuestao)
        {
            _questaoService.Update(novaQuestao);
            return Ok();
        }
    }
}
