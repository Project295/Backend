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
    public class UserSkillRepository: IUserSkillRepository
    {
        private readonly IDbContext _dbContext;

        public UserSkillRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<UserSkill> GetAllUserSkill()
        {
            return null;

        }

        public UserSkill GetUserSkillById(int id)
        {
            return null;

        }

        public void CreateUserSkill(UserSkill userSkill)
        {

        }

        public void UpdateUserSkill(UserSkill userSkill)
        {

        }

        public void DeleteUserSkill(int id)
        {

        }
    }
}
