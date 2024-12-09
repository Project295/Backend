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
        public List<UserExperience> GetAllUserExperience()
        {
            return null;

        }
        [HttpGet]
        [Route("GetUserExperienceById")]
        public UserExperience GetUserExperienceById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateUserExperience")]
        public void CreateUserExperience(UserExperience userExperience)
        {

        }
        [HttpPut]
        [Route("UpdateUserExperience")]
        public void UpdateUserExperience(UserExperience userExperience)
        {

        }
        [HttpDelete]
        [Route("DeleteUserExperience")]
        public void DeleteUserExperience(int id)
        {

        }
    }
}
