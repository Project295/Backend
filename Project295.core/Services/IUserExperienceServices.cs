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
        List<UserExperience> GetAllUserExperience();
        UserExperience GetUserExperienceById(int id);
        void CreateUserExperience(UserExperience userExperience);
        void UpdateUserExperience(UserExperience userExperience);
        void DeleteUserExperience(int id);
    }
}
