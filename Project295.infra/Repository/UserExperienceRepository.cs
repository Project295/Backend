using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class UserExperienceRepository: IUserExperienceRepository
    {
        private readonly IDbContext _dbContext;

        public UserExperienceRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
