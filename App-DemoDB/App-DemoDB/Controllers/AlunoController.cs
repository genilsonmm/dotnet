using App_DemoDB.Data;
using App_DemoDB.Entity;
using App_DemoDB.Model;
using App_DemoDB.Repository;
using App_DemoDB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_DemoDB.Controllers
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

        [HttpPost]
        public ActionResult Cadastrar([FromBody] AlunoDTO aluno)
        {
            return Ok(alunoService.Cadastrar(aluno));
        }

        [HttpGet]
        public ActionResult ObterTodos()
        {
            return Ok(alunoService.ObterTodos());
        }

        [HttpGet("{id}")]
        public ActionResult ObterPorId(int id)
        {
            return Ok(alunoService.ObterPorId(id));
        }

        [HttpGet("maiores")]
        public ActionResult ObterMaiores()
        {
            return Ok(alunoService.ObterMaiores());
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            alunoService.Deletar(id);
            return Ok("Aluno removido com sucesso");
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] Aluno aluno)
        {
            return Ok(alunoService.Atualizar(aluno));
        }
    }
}
