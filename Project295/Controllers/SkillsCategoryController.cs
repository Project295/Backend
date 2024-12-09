using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsCategoryController : ControllerBase
    {
        private readonly ISkillsCategoryServices _skillsCategoryServices;
        public SkillsCategoryController(ISkillsCategoryServices skillsCategoryServices)
        {
            _skillsCategoryServices = skillsCategoryServices;
        }
        [HttpGet]
        public Task<List<SkillsCategory>> GetAllSkillsCategory()
        {
            return _skillsCategoryServices.GetAllSkillsCategory();

        }
        [HttpGet]
        [Route("GetSkillsCategoryById")]
        public Task<SkillsCategory> GetSkillsCategoryById(int id)
        {
            return _skillsCategoryServices.GetSkillsCategoryById(id);

        }
        [HttpPost]
        [Route("CreateSkillsCategory")]
        public Task CreateSkillsCategory(SkillsCategory skillsCategory)
        {
            return _skillsCategoryServices.CreateSkillsCategory(skillsCategory);
        }
        [HttpPut]
        [Route("UpdateSkillsCategory")]
        public Task UpdateSkillsCategory(SkillsCategory skillsCategory)
        {
            return _skillsCategoryServices.UpdateSkillsCategory(skillsCategory);    
        }
        [HttpDelete]
        [Route("DeleteSkillsCategory")]
        public Task DeleteSkillsCategory(int id)
        {
            return _skillsCategoryServices.DeleteSkillsCategory(id);
        }
    }
}
