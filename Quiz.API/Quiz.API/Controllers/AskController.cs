using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.API.Data;
using Quiz.API.Data.Entity;
using Quiz.API.Data.Repository;
using Quiz.API.Data.Services;
using Quiz.API.Dto;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AskController : ControllerBase
    {
        private readonly AskService _skService;

        public AskController(AskService askService) 
        {
            _skService = askService;
        }

        [HttpPost]
        public ActionResult Post([FromBody] AskDTO askDto) 
        {
            return Ok(_skService.Insert(askDto));
        }      

        [HttpGet]
        public ActionResult Get() => Ok(_skService.GetAll());

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _skService.Delete(id);
            return Ok();
        }
    }
}
