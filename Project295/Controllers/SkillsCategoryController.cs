using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsCategoryController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public SkillsCategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<SkillsCategory> GetAllSkillsCategory()
        {
            return _dbContext.SkillsCategories.ToList();

        }
        [HttpGet]
        [Route("GetSkillsCategoryById")]
        public SkillsCategory GetSkillsCategoryById(int id)
        {
            return _dbContext.SkillsCategories.FirstOrDefault(x=>x.SkillsCategoryId==id);

        }
        [HttpPost]
        [Route("CreateSkillsCategory")]
        public void CreateSkillsCategory([FromBody] SkillsCategory skillsCategory)
        {
            if (skillsCategory == null)
            {
                throw new ArgumentNullException(nameof(skillsCategory), "Invalid data.");
            }

            _dbContext.SkillsCategories.Add(skillsCategory);
            _dbContext.SaveChanges();
        }
        [HttpPut]
        [Route("UpdateSkillsCategory")]
        public void UpdateSkillsCategory([FromBody]  SkillsCategory skillsCategory)
        {

            _dbContext.SkillsCategories.Update(skillsCategory);
            _dbContext.SaveChanges();
        }
        [HttpDelete]
        [Route("DeleteSkillsCategory/{id}")]
        public void DeleteSkillsCategory(int id)
        {
            var skillsCategory = _dbContext.SkillsCategories
                                           .FirstOrDefault(x => x.SkillsCategoryId == id);

            if (skillsCategory == null)
            {
                throw new Exception($"Skills Category with ID {id} not found.");
            }

            _dbContext.SkillsCategories.Remove(skillsCategory);
            _dbContext.SaveChanges();
        }


    }
}
