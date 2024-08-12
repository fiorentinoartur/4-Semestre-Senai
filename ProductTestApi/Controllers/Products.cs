using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductTestApi.Domain;
using ProductTestApi.Interfaces;
using ProductTestApi.Repositories;

namespace ProductTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class Products : ControllerBase
    {
        private IProduct productRepositorie { get; set; }
        public Products()
        {
            productRepositorie = new ProductRepositorie();
        }

        [HttpGet("ListarTodas")]
        public IActionResult Get()
        {
            return Ok(productRepositorie.Listar());
        }

        [HttpPost("Criar")]
        public IActionResult Post(Product products)
        {
            productRepositorie.Cadastrar(products);
            return StatusCode(201);
        }

        [HttpGet("BuscarPorId")]
        public IActionResult Get(Guid id) 
        {
            return Ok(productRepositorie.ListarPorId(id));
        }

        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            productRepositorie.Deletar(id);

            return NoContent();
        }

        [HttpPut("id")]
        public IActionResult Put(Product products) 
        {
            productRepositorie.AtualizarProduto(products);

            return NoContent();
        }
    }
}
