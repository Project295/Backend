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
        public List<Skill> GetAllSkills()
        {
            return null;

        }

        public Skill GetSkillById(int id)
        {
            return null;

        }

        public void CreateSkill(Skill skill)
        {

        }

        public void UpdateSkill(Skill skill)
        {

        }

        public void DeleteSkill(int id)
        {

        }
    }
}
