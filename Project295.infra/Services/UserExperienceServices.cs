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
    public class UserExperienceServices: IUserExperienceServices
    {
        private readonly IUserExperienceRepository _userExperienceRepository;
        public UserExperienceServices(IUserExperienceRepository userExperienceRepository)
        {
            _userExperienceRepository = userExperienceRepository;
        }
        public List<UserExperience> GetAllUserExperience()
        {
            return null;

        }

        public UserExperience GetUserExperienceById(int id)
        {
            return null;

        }

        public void CreateUserExperience(UserExperience userExperience)
        {

        }

        public void UpdateUserExperience(UserExperience userExperience)
        {

        }

        public void DeleteUserExperience(int id)
        {

        }
    }
}
