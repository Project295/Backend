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
        public List<User> GetAllUsers()
        {
            return null;

        }
        [HttpGet]
        [Route("GetUserById")]
        public User GetUserById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(User user)
        {

        }
        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateUser(User user)
        {

        }
        [HttpDelete]
        [Route("DeleteUser")]
        public void DeleteUser(int id)
        {

        }
    }
}
