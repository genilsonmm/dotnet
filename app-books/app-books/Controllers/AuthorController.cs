using app_books.Data;
using app_books.Dto;
using app_books.Entity;
using app_books.Service;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService; 
        }

        [HttpPost]
        public ActionResult Create([FromBody] AuthorRequest author)
            => Created("", _authorService.Create(author));

        [HttpGet]
        public ActionResult GetAll() => Ok(_authorService.GetAll());

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _authorService.Delete(id);
            return Ok("Autor removido com sucesso");
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] AuthorRequest author, int id) =>
            Ok(_authorService.Update(id, author));

        /*
        [HttpGet("{id}")]
        public AuthorResponse GetAuhorById(int id)
        {
            Author author = _dataContext.Authors.FirstOrDefault(a => a.AuthorId == id);
            return _mapper.Map<AuthorResponse>(author);
        }*/
    }
}
