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
        public List<SkillsCategory> GetAllSkillsCategory()
        {
            return null;

        }
        [HttpGet]
        [Route("GetSkillsCategoryById")]
        public SkillsCategory GetSkillsCategoryById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateSkillsCategory")]
        public void CreateSkillsCategory(SkillsCategory skillsCategory)
        {

        }
        [HttpPut]
        [Route("UpdateSkillsCategory")]
        public void UpdateSkillsCategory(SkillsCategory skillsCategory)
        {

        }
        [HttpDelete]
        [Route("DeleteSkillsCategory")]
        public void DeleteSkillsCategory(int id)
        {

        }
    }
}
