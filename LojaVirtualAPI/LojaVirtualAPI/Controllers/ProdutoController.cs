using LojaVirtualAPI.Db;
using LojaVirtualAPI.Dto;
using LojaVirtualAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtualAPI.Controllers
{
    //localhost:<port>/api/produto
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public ProdutoController()
        {

        }

        [HttpGet]
        public ResponseDTO<List<Produto>> Get()
        {
            ResponseDTO<List<Produto>> responseDTO = new ResponseDTO<List<Produto>>();
            responseDTO.Object = Database.produtos;
            responseDTO.StatusCode = Ok().StatusCode;
            
            return responseDTO;
        }

        //http://localhost:5124/api/produto/AB123
        [HttpGet("{lote}")]
        public ActionResult ObterPorLote(string lote)
        {
            ResponseDTO<Produto> responseDTO = new ResponseDTO<Produto>();
            Produto produto = ObterProdutoPeloLote(lote);

            if (produto == null) {

                responseDTO.Messages.Add("Lote inválido!");
                responseDTO.StatusCode = NoContent().StatusCode;
                return Ok(responseDTO);
            }

            
            responseDTO.Object = produto;

            return Ok();
        }

        [HttpDelete("{lote}")]
        public ActionResult<string> Delete(string lote)
        {
            Produto produto = ObterProdutoPeloLote(lote);
            
            if (produto == null)
                return NoContent();

            Database.produtos.Remove(produto);

            return Ok("Produto removido com sucesso!");
        }

        //http://localhost:5124/api/produto
        [HttpPost]
        public ActionResult Cadastrar([FromBody] Produto produto)
        {
            Database.produtos.Add(produto);
            return Created("", produto);
        }


        [HttpPut]
        public ActionResult Put([FromBody] Produto produto)
        {
            Produto produtoEditado = ObterProdutoPeloLote(produto.Lote);
            if (produtoEditado == null)
                return NoContent();

            produtoEditado.Nome = produto.Nome;
            produtoEditado.Quantidade = produto.Quantidade;

            return Ok(produtoEditado);
        }

        private Produto ObterProdutoPeloLote(string lote)
        {
            return Database.produtos.Find(item => item.Lote.Equals(lote));
        }
    }
}