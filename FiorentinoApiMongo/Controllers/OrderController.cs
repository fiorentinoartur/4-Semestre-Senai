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

            foreach (var item in orders)
            {
                item.Client = await _client.Find(x => x.Id == item.ClientId).FirstOrDefaultAsync();

                item.Products = new List<Product>();
                foreach (var item1 in item.ProductId)
                {
                    var product = await _product.Find(x => x.Id == item1).FirstOrDefaultAsync();
                    item.Products.Add(product);
                }
            }

            return Ok(orders);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Order>> GetById(string id)
        {
            var orders = await _orders.Find(x => x.Id == id).FirstOrDefaultAsync();


            orders.Client = await _client.Find(x => x.Id == orders.ClientId).FirstOrDefaultAsync();

            orders.Products = new List<Product>();
            foreach (var item1 in orders.ProductId)
            {
                var product = await _product.Find(x => x.Id == item1).FirstOrDefaultAsync();
                orders.Products.Add(product);
            }
            return Ok(orders);
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
        public async Task<ActionResult<Order>> Put(OrderViewModel order)
        {
            var ord = await _orders.Find(x => x.Id == order.Id).FirstOrDefaultAsync();

            if(order.Date != null)
            ord.Date = order.Date;

            if(order.Status != null)
            ord.Status = order.Status;

            if(order.ProductId != null)
            ord.ProductId = order.ProductId;

            if(order.ClientId != null)
            ord.ClientId = order.ClientId;

            var client = _client.Find(x => x.Id == ord.ClientId).FirstOrDefaultAsync();

            if (client == null)
                return NotFound();

            await _orders.ReplaceOneAsync(x => x.Id == order.Id, ord);

            return NoContent();

        }
        [HttpDelete("id")]
        public async Task<ActionResult<Order>> Delete(string id)
        {
            await _orders.DeleteOneAsync(x => x.Id == id);

            return NoContent();
        }


    }
}
