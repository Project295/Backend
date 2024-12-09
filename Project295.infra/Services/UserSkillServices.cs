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
    public class UserSkillServices: IUserSkillServices
    {
        private readonly IUserSkillRepository _userSkillRepository;
        public UserSkillServices(IUserSkillRepository userSkillRepository)
        {
            _userSkillRepository = userSkillRepository;
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
