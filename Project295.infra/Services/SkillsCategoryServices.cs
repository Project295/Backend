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
        public Task<List<SkillsCategory>> GetAllSkillsCategory()
        {
            return _skillsCategoryRepository.GetAllSkillsCategory();

        }

        public Task<SkillsCategory> GetSkillsCategoryById(int id)
        {
            return _skillsCategoryRepository.GetSkillsCategoryById(id);

        }

        public Task CreateSkillsCategory(SkillsCategory skillsCategory)
        {
            return _skillsCategoryRepository.CreateSkillsCategory(skillsCategory);  
        }

        public Task UpdateSkillsCategory(SkillsCategory skillsCategory)
        {
            return _skillsCategoryRepository.UpdateSkillsCategory(skillsCategory);
        }

        public Task DeleteSkillsCategory(int id)
        {
            return _skillsCategoryRepository.DeleteSkillsCategory(id);
        }
    }
}
