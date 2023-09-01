using EscolaAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace EscolaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> alunos = new List<Aluno>();

        [HttpGet("todos")]
        public ActionResult Teste()
        {
            return Ok(alunos);
        }


        //localhost:5204/api/aluno
        [HttpGet("uyiuyiy")]
        public List<string> Alunos()
        {
            return new List<string>()
            {
                "Maria", "João", "Marta"
            };
        }

        //localhost:5204/api/aluno/pagina/10
        [HttpGet("pagina/{numero}")]
        public string Get(string texto)
        {
            return "Voltei da API " + texto;
        }

        [HttpGet("detalhes")]
        public Aluno Detalhes() => new Aluno() { Id = Guid.NewGuid(), Idade= 30, Nome= "Fulano" };
      

        [HttpPost]
        public void Post([FromBody] Aluno aluno)
        {
            alunos.Add(aluno);
        }
    }
}
