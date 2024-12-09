using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSkillController : ControllerBase
    {
        private readonly IUserSkillServices _userSkillServices;
        public UserSkillController(IUserSkillServices userSkillServices)
        {
            _userSkillServices = userSkillServices;
        }
        [HttpGet]
        public Task<List<UserSkill>> GetAllUserSkill()
        {
           return _userSkillServices.GetAllUserSkill();

        }
        [HttpGet]
        [Route("GetUserSkillById")]
        public Task<UserSkill> GetUserSkillById(int id)
        {
            return _userSkillServices.GetUserSkillById(id);

        }
        [HttpPost]
        [Route("CreateUserSkill")]
        public Task CreateUserSkill(UserSkill userSkill)
        {
            return _userSkillServices.UpdateUserSkill(userSkill);
        }
        [HttpPut]
        [Route("UpdateUserSkill")]
        public  Task UpdateUserSkill(UserSkill userSkill)
        {
            return  _userSkillServices.UpdateUserSkill(userSkill);
        }
        [HttpDelete]
        [Route("DeleteUserSkill")]
        public Task DeleteUserSkill(int id)
        {
            return _userSkillServices.DeleteUserSkill(id);
        }
    }
}
