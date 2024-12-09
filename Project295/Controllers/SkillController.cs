using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillServices _skillServices;
        public SkillController(ISkillServices skillServices)
        {
            _skillServices = skillServices;
        }
        [HttpGet]
        public List<Skill> GetAllSkills()
        {
            return null;

        }
        [HttpGet]
        [Route("GetSkillById")]
        public Skill GetSkillById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateSkill")]
        public void CreateSkill(Skill skill)
        {

        }
        [HttpPut]
        [Route("UpdateSkill")]
        public void UpdateSkill(Skill skill)
        {

        }
        [HttpDelete]
        [Route("DeleteSkill")]
        public void DeleteSkill(int id)
        {

        }
    }
}
