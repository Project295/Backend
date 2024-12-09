using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [HttpGet]
        public Task<List<User>> GetAllUsers()
        {
            return _userServices.GetAllUsers();

        }
        [HttpGet]
        [Route("GetUserById")]
        public Task<User> GetUserById(int id)
        {
            return _userServices.GetUserById(id);

        }
        [HttpPost]
        [Route("CreateUser")]
        public Task CreateUser(User user)
        {
            return _userServices.CreateUser(user);
        }
        [HttpPut]
        [Route("UpdateUser")]
        public Task UpdateUser(User user)
        {
            return _userServices.UpdateUser(user);

        }
        [HttpDelete]
        [Route("DeleteUser")]
        public Task DeleteUser(int id)
        {
            return _userServices.DeleteUser(id);
        }
    }
}
