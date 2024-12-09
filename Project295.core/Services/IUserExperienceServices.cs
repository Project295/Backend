using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface IUserExperienceServices
    {
         Task<List<UserExperience>> GetAllUserExperience();
         Task<UserExperience> GetUserExperienceById(int id);
         Task CreateUserExperience(UserExperience userExperience);
         Task UpdateUserExperience(UserExperience userExperience);
         Task DeleteUserExperience(int id);
    }
}
