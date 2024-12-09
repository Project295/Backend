using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class SkillRepository: ISkillRepository
    {
        private readonly IDbContext _dbContext;

        public SkillRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
