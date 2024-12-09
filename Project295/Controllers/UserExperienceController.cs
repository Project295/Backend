using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserExperienceController : ControllerBase
    {
        private readonly IUserExperienceServices _userExperienceServices;
        public UserExperienceController(IUserExperienceServices userExperienceServices)
        {
            _userExperienceServices = userExperienceServices;
        }
        [HttpGet]
        public  Task<List<UserExperience>> GetAllUserExperience()
        {
            return _userExperienceServices.GetAllUserExperience();

        }
        [HttpGet]
        [Route("GetUserExperienceById")]
        public  Task<UserExperience> GetUserExperienceById(int id)
        {
            return _userExperienceServices.GetUserExperienceById(id);

        }
        [HttpPost]
        [Route("CreateUserExperience")]
        public  Task CreateUserExperience(UserExperience userExperience)
        {
            return _userExperienceServices.CreateUserExperience(userExperience);
        }
        [HttpPut]
        [Route("UpdateUserExperience")]
        public Task UpdateUserExperience(UserExperience userExperience)
        {
            return _userExperienceServices.UpdateUserExperience(userExperience);
        }
        [HttpDelete]
        [Route("DeleteUserExperience")]
        public Task DeleteUserExperience(int id)
        {
            return _userExperienceServices.DeleteUserExperience(id);
        }
    }
}
