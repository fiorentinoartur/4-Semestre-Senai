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
            mongoDbService.GetDatabase.GetCollection<User>("user");
        }



        //[HttpGet]
        //public async Task<IActionResult<List<User>>> Get()
        //{

        //}
    }
}
