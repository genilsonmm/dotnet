using LojaVirtualAPI.Db;
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
        public List<Produto> Get()
        {
            return Database.produtos;
        }

        //http://localhost:5124/api/produto/AB123
        [HttpGet("{lote}")]
        public Produto ObterPorLote(string lote)
        {
            return Database.produtos.Find(item => item.Lote.Equals(lote));
        }

        //http://localhost:5124/api/produto
        [HttpPost("cadastrar")]
        public Produto Cadastrar([FromBody] Produto produto)
        {
            Database.produtos.Add(produto);
            return produto;
        }

    }
}