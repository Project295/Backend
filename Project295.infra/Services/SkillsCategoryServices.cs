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
    public class SkillsCategoryServices: ISkillsCategoryServices
    {
        private readonly ISkillsCategoryRepository _skillsCategoryRepository;
        public SkillsCategoryServices(ISkillsCategoryRepository skillsCategoryRepository)
        {
            _skillsCategoryRepository = skillsCategoryRepository;
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
