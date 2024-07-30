using FiorentinoApiMongo.Domains;
using FiorentinoApiMongo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace FiorentinoApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IMongoCollection<User> _users;

        public UserController(MongoDbService mongoDbService)
        {
          _users =  mongoDbService.GetDatabase.GetCollection<User>("user");

        }



        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            var users = await _users.Find(FilterDefinition<User>.Empty).ToListAsync();

            return Ok(users);
        }

        [HttpGet("id")]
        public async Task<ActionResult<User>> GetById(string id)
        {
            var user = await _users.Find(x => x.Id == id).FirstOrDefaultAsync();

            return Ok(user);
        }


        [HttpDelete("id")]
        public async Task<ActionResult<User>> Delete(string id)
        {
            var user = await _users.DeleteOneAsync(x => x.Id == id);

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
        {
            await _users.InsertOneAsync(user);

            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult<User>> Put(User user)
        {
            await _users.ReplaceOneAsync(x => x.Id == user.Id, user);

            return NoContent();
        }
    }
}
