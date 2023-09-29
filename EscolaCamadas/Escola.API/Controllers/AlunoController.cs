using Escola.Dados.Entidades;
using Escola.Dados.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Escola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoRepository alunoRepository;

        public AlunoController(AlunoRepository alunoRepository)
        {
            this.alunoRepository = alunoRepository;
        }

        [HttpGet]
        public ActionResult Get() => Ok(alunoRepository.GetAll());

        [HttpPost]
        public ActionResult Post([FromBody] Aluno aluno)
        {
            alunoRepository.Add(aluno);
            return Created("", aluno);
        }

        [HttpPut()]
        public ActionResult Put([FromBody] Aluno aluno)
        {
            alunoRepository.Update(aluno);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            alunoRepository.Delete(id);
            return Ok("Aluno removido");
        }
    }
}
