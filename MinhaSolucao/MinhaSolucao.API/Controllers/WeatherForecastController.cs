using Microsoft.AspNetCore.Mvc;
using MinhaSolucao.DATA;

namespace MinhaSolucao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            Calculadora calculadora = new Calculadora();
            decimal result = calculadora.Somar(5, 2);
            return Ok(new
            {
                valor = result
            });
        }
    }
}
