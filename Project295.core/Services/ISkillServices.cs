using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface ISkillServices
    {
        Task<List<Skill>> GetAllSkills();
        Task<Skill> GetSkillById(int id);
        Task CreateSkill(Skill skill);
        Task UpdateSkill(Skill skill);
        Task DeleteSkill(int id);
    }
}
