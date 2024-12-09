using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using Project295.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class SkillsCategoryRepository: ISkillsCategoryRepository
    {
        private readonly IDbContext _dbContext;

        public SkillsCategoryRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SkillsCategory> GetAllSkillsCategory()
        {
            return null;

        }

        public SkillsCategory GetSkillsCategoryById(int id)
        {
            return null;

        }

        public void CreateSkillsCategory(SkillsCategory skillsCategory)
        {

        }

        public void UpdateSkillsCategory(SkillsCategory skillsCategory)
        {

        }

        public void DeleteSkillsCategory(int id)
        {

        }
    }
}
