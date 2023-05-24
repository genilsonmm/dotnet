using Microsoft.AspNetCore.Mvc;
using Quiz.DATA.Entity;
using Quiz.DATA.Repository;
using Quiz.DATA.Service;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly QuestaoService _questaoService;

        public QuizController(QuestaoService questaoService) 
        {
            _questaoService = questaoService;
        }

        [HttpPost]
        public ActionResult<Questao> Insert([FromBody] Questao questao)
        {
            return _questaoService.Insert(questao);
        }

        [HttpGet]
        public ActionResult<List<Questao>> GetAll() =>
             _questaoService.GetAll();


        [HttpGet("{id}")]
        public ActionResult<Questao> GetById(int id) => _questaoService.GetById(id);
            

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _questaoService.DeleteById(id);
            return Ok();
        }

        [HttpGet("resultado")]
        public IActionResult Resultado() 
        {
            _questaoService.Resultado(
                out double nota, 
                out int resultado, 
                out int qntQuestoes);

            return Ok(new
            {
                Resultado = $"{qntQuestoes}/{resultado}",
                Nota = nota
            });
        }  
    }
}
