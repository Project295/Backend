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
        public  Task<List<UserExperience>> GetAllUserExperience()
        {
            return _userExperienceRepository.GetAllUserExperience();

        }

        public  Task<UserExperience> GetUserExperienceById(int id)
        {
            return _userExperienceRepository.GetUserExperienceById(id);

        }

        public  Task CreateUserExperience(UserExperience userExperience)
        {
            return _userExperienceRepository.CreateUserExperience(userExperience);
        }

        public  Task UpdateUserExperience(UserExperience userExperience)
        {
            return _userExperienceRepository.UpdateUserExperience(userExperience);
        }

        public  Task DeleteUserExperience(int id)
        {
            return _userExperienceRepository.DeleteUserExperience(id);
        }
    }
}
