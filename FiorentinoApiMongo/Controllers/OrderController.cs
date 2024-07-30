using FiorentinoApiMongo.Domains;
using FiorentinoApiMongo.Services;
using FiorentinoApiMongo.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace FiorentinoApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    public class OrderController : ControllerBase
    {

        private readonly IMongoCollection<Order> _orders;
        private readonly IMongoCollection<Client> _client;
        private readonly IMongoCollection<Product> _product;

        public OrderController(MongoDbService mongoDbService)
        {
            _orders = mongoDbService.GetDatabase.GetCollection<Order>("order");
            _client = mongoDbService.GetDatabase.GetCollection<Client>("client");
            _product = mongoDbService.GetDatabase.GetCollection<Product>("product");
        }
        [HttpGet]
        public async Task<ActionResult<List<Order>>> Get()
        {
            var orders = await _orders.Find(FilterDefinition<Order>.Empty).ToListAsync();

            return Ok(orders);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Order>> GetById(string id)
        {
            var order = await _client.Find(x => x.Id == id).FirstOrDefaultAsync();

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Post(OrderViewModel order)
        {
            Order ord = new Order();
            ord.Id = order.Id;
            ord.Date = order.Date;
            ord.Status = order.Status;
            ord.ProductId = order.ProductId;
            ord.ClientId = order.ClientId;

            var client = _client.Find(x => x.Id == ord.ClientId).FirstOrDefaultAsync();

            if (client == null)
                return NotFound();

                await _orders.InsertOneAsync(ord);

            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult<Order>> Put(Order order)
        {
            await _orders.ReplaceOneAsync(x => x.Id == order.Id, order);

            return NoContent();
        }
        [HttpDelete("id")]
        public async Task<ActionResult<Order>> Delete(string id)
        {
            await _orders.DeleteManyAsync(x => x.Id == id);

            return NoContent();
        }


    }
}
