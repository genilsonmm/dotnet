using Escola.Dados.Dto;
using Escola.Dados.Entidades;
using Escola.Dados.Repository;
using Escola.Dados.Service;
using Microsoft.AspNetCore.Mvc;

namespace Escola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoService alunoService;

        public AlunoController(AlunoService alunoService)
        {
            this.alunoService = alunoService;
        }

        /*
        [HttpGet]
        public ActionResult Get() => Ok(alunoRepository.GetAll());
        */
        [HttpPost]
        public ActionResult Post([FromBody] AlunoDTO aluno)
        {
            alunoService.Add(aluno);
            return Created("", aluno);
        }
        /*

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
        }*/
    }
}
