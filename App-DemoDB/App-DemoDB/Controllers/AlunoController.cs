using App_DemoDB.Data;
using App_DemoDB.Entity;
using App_DemoDB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_DemoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext dataContext;

        public AlunoController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpPost]
        public ActionResult Cadastrar([FromBody] AlunoDTO aluno)
        {
            Aluno novoAluno = aluno.ToAluno(aluno);
            this.dataContext.Alunos.Add(novoAluno);
            this.dataContext.SaveChanges();

            return Ok(aluno);
        }

        [HttpGet]
        public ActionResult ObterTodos()
        {
            return Ok(this.dataContext.Alunos.Include(a=>a.Notas).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult ObterPorId(int id)
        {
            Aluno alunoEncontrado = this.dataContext.Alunos.Find(id);
            return Ok(alunoEncontrado);
        }

        [HttpGet("maiores")]
        public ActionResult ObterMaiores()
        {
            List<Aluno> alunos = 
                this.dataContext.Alunos.Where(aluno => aluno.Age > 18).ToList();
            return Ok(alunos);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Aluno alunoEncontrado = this.dataContext.Alunos.Find(id);
            this.dataContext.Alunos.Remove(alunoEncontrado);
            this.dataContext.SaveChanges();

            return Ok("Aluno removido com sucesso");
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] Aluno aluno)
        {
            this.dataContext.Entry(aluno).State = EntityState.Modified;
            this.dataContext.SaveChanges();
            return Ok(aluno);
        }
    }
}
