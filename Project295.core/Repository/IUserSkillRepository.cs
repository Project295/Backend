using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IUserSkillRepository
    {
        Task<List<UserSkill>> GetAllUserSkill();
         Task<UserSkill> GetUserSkillById(int id);
         Task CreateUserSkill(UserSkill userSkill);
         Task UpdateUserSkill(UserSkill userSkill);
         Task DeleteUserSkill(int id);
    }
}
