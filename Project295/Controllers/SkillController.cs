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
        public void CreateSkill([FromBody] Skill skill)
        {
            if(skill == null)
            {
                throw new ArgumentNullException(nameof(skill), "Invalid data.");
            }

            _dbContext.Skills.Add(new Skill
            {
                SkillName = skill.SkillName,
                SkillCategoryId = skill.SkillCategoryId
            });

            _dbContext.SaveChanges();

        }
        [HttpPut]
        [Route("UpdateSkill")]
        public void UpdateSkill([FromBody] Skill skill)
        {
            var existingSkill = _dbContext.Skills.FirstOrDefault(x => x.SkillId == skill.SkillId);
            if (existingSkill == null)
            {
                throw new KeyNotFoundException("Skill not found.");
            }

            existingSkill.SkillName = skill.SkillName ?? existingSkill.SkillName; 

            _dbContext.SaveChanges();

        }
        [HttpDelete]
        [Route("DeleteSkill/{id}")]
        public void DeleteSkill(int id)
        {
            var skill = _dbContext.Skills.FirstOrDefault(x => x.SkillId == id);
            if(skill == null)
            {
                throw new Exception($"Skill with ID {id} not found.");
            }

            _dbContext.Skills.Remove(skill);
            _dbContext.SaveChanges();

        }

        [HttpGet]
        [Route("GetSkillsByCategoryId/{id}")]
        public IEnumerable<Skill> GetSkillsByCategoryId(int id)
        {
            return _dbContext.Skills.Where(x => x.SkillCategoryId == id).ToList();
        }
    }
}
