using Amazon.Runtime;
using FiorentinoApiMongo.Domains;
using FiorentinoApiMongo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FiorentinoApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// Armazena os dados de acesso da collection
        /// </summary>
        private readonly IMongoCollection<Product> _product;

        /// <summary>
        /// Construtor que recebe como dependência o obj da classe MongoDbService
        /// </summary>
        /// <param name="mongoDbService"> obj da classe MongoDbService</param>
        public ProductController(MongoDbService mongoDbService)
        {
            //Obtem a collection "product"
            _product = mongoDbService.GetDatabase.GetCollection<Product>("product");
        }

        //Buscar Produtos
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var products = await _product.Find(FilterDefinition<Product>.Empty).ToListAsync();

              return Ok(products);  
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        //Cadastrar Produto
        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product p)
        {
            await _product.InsertOneAsync(p);
           return Ok(p);    
            
        }
        
        //Deletar Produto
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete(string id)
        {
            var product = await _product.FindOneAndDeleteAsync(x => x.Id == id);

           return StatusCode(201);    
            
        }
      
        //Atualizar Produto
        [HttpPut]
        public async Task<ActionResult<Product>> UpdateObject(Product p)
        {

            await _product.ReplaceOneAsync(x => x.Id == p.Id, p);

            return StatusCode(201);
        }
        
        //Buscar pelo id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(string id)
        {
            var produto = await _product.Find(x => x.Id == id).FirstOrDefaultAsync();
            return produto == null ? NotFound() : Ok(produto);
        }



       
}
}
