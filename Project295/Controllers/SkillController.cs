using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;


namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public SkillController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Skill> GetAllSkills()
        {
            return _dbContext.Skills.ToList();

        }
        [HttpGet]
        [Route("GetSkillById")]
        public Skill GetSkillById(int id)
        {
            return _dbContext.Skills.FirstOrDefault(x=>x.SkillId == id);

        }
        [HttpPost]
        [Route("CreateSkill")]
        public void CreateSkill(Skill skill)
        {
            _dbContext.Skills.Add(skill);
        }
        [HttpPut]
        [Route("UpdateSkill")]
        public void UpdateSkill(Skill skill)
        {
            _dbContext.Skills.Update(skill);
        }
        [HttpDelete]
        [Route("DeleteSkill")]
        public void DeleteSkill(int id)
        {
            var skill = _dbContext.Skills.FirstOrDefault(x => x.SkillId == id);
            _dbContext.Skills.Remove(skill);
        }
    }
}
