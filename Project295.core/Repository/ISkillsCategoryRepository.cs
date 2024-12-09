using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface ISkillsCategoryRepository
    {
         List<SkillsCategory> GetAllSkillsCategory();
         SkillsCategory GetSkillsCategoryById(int id);
         void CreateSkillsCategory(SkillsCategory skillsCategory);
         void UpdateSkillsCategory(SkillsCategory skillsCategory);
         void DeleteSkillsCategory(int id);
    }
}
