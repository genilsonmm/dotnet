using CryptoManagement.Data;
using CryptoManagement.Data.Dto;
using CryptoManagement.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Crypto.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinController : ControllerBase
    {

        private readonly CoinRepository _coinRepository;

        public CoinController(DataContext dataContext)
        {
            _coinRepository = new CoinRepository(dataContext);
        }

        [HttpGet("byId/{id}")]
        public ActionResult GetById(int id)
        {
            return Ok(_coinRepository.GetById(id));
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_coinRepository.GetAll());
        }


        [HttpGet("{name}")]
        public ActionResult GetByName(string name)
        {
            return Ok(_coinRepository.GetByName(name));
        }

        [HttpGet("unique")]
        public ActionResult GetUnique()
        {
            return Ok(_coinRepository.GetUnique());
        }

        [HttpPost]
        public ActionResult Post([FromBody] CoinDTO coin)
        {
            if (!ValidateFields(coin))
            {
                return Ok("Campos inválidos!");
            }

            coin.DateTime = DateTime.Now;
            coin.Name = coin.Name.ToUpper();

            _coinRepository.Add(coin);

            return Ok("Coin adicionada com sucesso!");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _coinRepository.Delete(id);
                return Ok("Moeda removida com sucesso!");
            }
            catch (ArgumentNullException)
            {
                return Ok("Moeda não encontrada");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Edit([FromBody] CoinDTO coinToEdit)
        {
            return Ok(_coinRepository.Edit(coinToEdit));
        }

        private bool ValidateFields(CoinDTO coin)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(coin.Name))
                valid = false;

            if (coin.Price <= 0)
                valid = false;

            return valid;
        }
    }
}
