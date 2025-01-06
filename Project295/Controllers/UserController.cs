using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public UserController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();

        }
        [HttpGet]
        [Route("GetUserById")]
        public User GetUserById(int id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserId == id);

        }
        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(User user)
        {
             _dbContext.Users.Add(user);
        }
        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateUser(User user)
        {
            _dbContext.Users.Update(user);

        }
        [HttpDelete]
        [Route("DeleteUser")]
        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
            _dbContext.Users.Remove(user);
        }
    }
}
