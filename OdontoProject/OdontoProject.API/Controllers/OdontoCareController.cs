using Microsoft.AspNetCore.Mvc;
using OdontoProject.API.Data;
using OdontoProject.API.Dto;
using OdontoProject.API.Entity;
using System.Diagnostics;

namespace OdontoProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdontoCareController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Database.odontoCare);
        }

        [HttpGet("{userId}")]
        public IActionResult Get(string id)
        {
            var results = Database.odontoCare
                .Where(care => care.UserId.ToString().Equals(id)).ToList();

            return Ok(results);
        }


        [HttpPost]
        public IActionResult Add([FromBody] OdontoCare odontoCare)
        {
            if (!UserIsValid(odontoCare.UserId))
                return NoContent();

            Database.odontoCare.Add(odontoCare);
            return Ok();
        }

        [HttpGet("care/{userId}")]
        public IActionResult GetByUserId(Guid userId)
        {
            //Pego o atendimento
            OdontoCare? odontoCare = Database.odontoCare.Where(o=> o.UserId == userId)
                                        .FirstOrDefault();
            
            var user = Database.users.Where(u=> u.Id == userId).FirstOrDefault();
            OdontoCareDTO odontoCareDTO = new OdontoCareDTO();
            odontoCareDTO.Name = user.Name;

            odontoCare?.Procedures.ForEach(procedureId =>
            {
                Procedure? procedure = Database.procedures.Where(p => p.Id == procedureId)
                        .FirstOrDefault();

                odontoCareDTO.Procedures.Add(procedure.Name);
            });

            return Ok(odontoCareDTO); ;
        }


        private bool UserIsValid(Guid userId)
        {
            return Database.users.Any(user => user.Id == userId);
        }
    }
}
