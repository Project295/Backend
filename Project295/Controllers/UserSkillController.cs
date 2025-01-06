using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSkillController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public UserSkillController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<UserSkill> GetAllUserSkill()
        {
           return _dbContext.UserSkills.ToList();

        }
        [HttpGet]
        [Route("GetUserSkillById")]
        public UserSkill GetUserSkillById(int id)
        {
            return _dbContext.UserSkills.FirstOrDefault(x => x.SkillId == id);

        }
        [HttpPost]
        [Route("CreateUserSkill")]
        public void CreateUserSkill(UserSkill userSkill)
        {
             _dbContext.UserSkills.Add(userSkill);
        }
        [HttpPut]
        [Route("UpdateUserSkill")]
        public  void UpdateUserSkill(UserSkill userSkill)
        {
            _dbContext.UserSkills.Update(userSkill);
        }
        [HttpDelete]
        [Route("DeleteUserSkill")]
        public void DeleteUserSkill(int id)
        {
            var userSkill = _dbContext.UserSkills.FirstOrDefault(x => x.SkillId == id);
            _dbContext.UserSkills.Remove(userSkill);
        }
    }
}
