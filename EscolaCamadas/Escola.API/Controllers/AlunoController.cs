using Escola.API.Dto;
using Escola.Dados;
using Escola.Dados.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Escola.API.Controllers
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

        [HttpGet]
        public ActionResult Get() => Ok(this.dataContext.Alunos.ToList());

        [HttpPost]
        public ActionResult Post([FromBody] Aluno aluno)
        {
            //Database.Instance().Alunos().Add(aluno);
            this.dataContext.Alunos.Add(aluno);
            this.dataContext.SaveChanges();

            return Created("", aluno);
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] ProvaDto prova, Guid id)
        {
            Aluno aluno = Database.Instance().Alunos().Find(aluno => aluno.AlunoId.Equals(id));
            //aluno.Notas.Add(prova.Nota);
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            Aluno aluno = Database.Instance().Alunos().Find(aluno => aluno.AlunoId.Equals(id));
            Database.Instance().Alunos().Remove(aluno);

            return Ok(aluno);
        }
    }
}
