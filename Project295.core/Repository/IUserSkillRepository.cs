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
         List<UserSkill> GetAllUserSkill();
         UserSkill GetUserSkillById(int id);
         void CreateUserSkill(UserSkill userSkill);
         void UpdateUserSkill(UserSkill userSkill);
         void DeleteUserSkill(int id);
    }
}
