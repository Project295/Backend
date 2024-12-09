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
        public Task<List<Skill>> GetAllSkills()
        {
            return _skillServices.GetAllSkills();

        }
        [HttpGet]
        [Route("GetSkillById")]
        public Task<Skill> GetSkillById(int id)
        {
            return _skillServices.GetSkillById(id);

        }
        [HttpPost]
        [Route("CreateSkill")]
        public Task CreateSkill(Skill skill)
        {
            return _skillServices.CreateSkill(skill);
        }
        [HttpPut]
        [Route("UpdateSkill")]
        public Task UpdateSkill(Skill skill)
        {
            return _skillServices.UpdateSkill(skill);
        }
        [HttpDelete]
        [Route("DeleteSkill")]
        public Task DeleteSkill(int id)
        {
            return _skillServices.DeleteSkill(id);
        }
    }
}
