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
        public List<UserSkill> GetAllUserSkill()
        {
            return null;

        }
        [HttpGet]
        [Route("GetUserSkillById")]
        public UserSkill GetUserSkillById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateUserSkill")]
        public void CreateUserSkill(UserSkill userSkill)
        {

        }
        [HttpPut]
        [Route("UpdateUserSkill")]
        public void UpdateUserSkill(UserSkill userSkill)
        {

        }
        [HttpDelete]
        [Route("DeleteUserSkill")]
        public void DeleteUserSkill(int id)
        {

        }
    }
}
