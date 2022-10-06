using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.DATA.Data;
using Quiz.DATA.Entity;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestaoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public QuestaoController(DataContext dataContext)
        {
            _dataContext = dataContext;

            Questao questao = new Questao();
            questao.Titulo = "Questão de teste";
            questao.AlternativaA = "Questão A";
            questao.AlternativaB = "Questão B";
            questao.AlternativaC = "Questão C";
            questao.AlternativaD = "Questão D";
            questao.AlternativaE = "Questão E";

            dataContext.Questao.Add(questao);
            dataContext.SaveChanges();
        }

        [HttpGet]
        public ActionResult<List<Questao>> Get()
        {
            return _dataContext.Questao.ToList();
        }
    }
}
