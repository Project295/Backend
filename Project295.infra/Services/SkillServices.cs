using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Services
{
    public class SkillServices: ISkillServices
    {
        private readonly ISkillRepository _skillRepository;
        public SkillServices(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        public Task<List<Skill>> GetAllSkills()
        {
            return _skillRepository.GetAllSkills();

        }

        public Task<Skill> GetSkillById(int id)
        {
            return _skillRepository.GetSkillById(id);

        }

        public Task CreateSkill(Skill skill)
        {
            return _skillRepository.CreateSkill(skill);
        }

        public Task UpdateSkill(Skill skill)
        {
            return _skillRepository.UpdateSkill(skill);
        }

        public Task DeleteSkill(int id)
        {
            return _skillRepository.DeleteSkill(id);
        }
    }
}
