using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project295.API.Common;
using Project295.API.DTO;
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
        [Route("GetUserSkillByUserId/{userId}")]
        public IActionResult GetUserSkillById(int userId)
        {
            var userSkills = _dbContext.UserSkills
                .Include(s=>s.Skill)
                .Where(x => x.UserId == userId)
                .Select(userSkill=> new GetAllUserSkillsDTO()
                {
                    UserSkillId = userSkill.UserSkillId,
                    UserId = userSkill.UserId,
                    SkillId = userSkill.SkillId,
                    SkillName = userSkill.Skill.SkillName,
                    CreatedAt = userSkill.CreatedAt
                }).ToList();

            return Ok(userSkills);
        }
        [HttpPost]
        [Route("CreateUserSkill")]
        public IActionResult CreateUserSkill(AddUserSkillsDTO addUserSkillsDTO)
        {
            var userSkill = new UserSkill()
            {
                UserId = addUserSkillsDTO.UserId,
                SkillId = addUserSkillsDTO.SkillId
            };
             _dbContext.UserSkills.Add(userSkill);
            _dbContext.SaveChanges();
            return Ok();
        }
        
        [HttpDelete]
        [Route("DeleteUserSkill/{userSkillId}")]
        public IActionResult DeleteUserSkill(int userSkillId)
        {
            var userSkill = _dbContext.UserSkills.FirstOrDefault(x => x.UserSkillId == userSkillId);
            _dbContext.UserSkills.Remove(userSkill);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
