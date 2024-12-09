using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface ISkillsCategoryServices
    {
        Task<List<SkillsCategory>> GetAllSkillsCategory();
        Task<SkillsCategory> GetSkillsCategoryById(int id);
        Task CreateSkillsCategory(SkillsCategory skillsCategory);
        Task UpdateSkillsCategory(SkillsCategory skillsCategory);
        Task DeleteSkillsCategory(int id);
    }
}
