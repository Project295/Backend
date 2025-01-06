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
        public void CreateSkillsCategory(SkillsCategory skillsCategory)
        {
             _dbContext.SkillsCategories.Add(skillsCategory);
        }
        [HttpPut]
        [Route("UpdateSkillsCategory")]
        public void UpdateSkillsCategory(SkillsCategory skillsCategory)
        {
            _dbContext.SkillsCategories.Update(skillsCategory);
        }
        [HttpDelete]
        [Route("DeleteSkillsCategory")]
        public void DeleteSkillsCategory(int id)
        {
            var skillsCategory = _dbContext.SkillsCategories.FirstOrDefault(x => x.SkillsCategoryId == id);
            _dbContext.SkillsCategories.Remove(skillsCategory);
        }
    }
}
