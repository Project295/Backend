using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;


namespace Project295.Infra.Services
{
    public class UserSkillServices: IUserSkillServices
    {
        private readonly IUserSkillRepository _userSkillRepository;
        public UserSkillServices(IUserSkillRepository userSkillRepository)
        {
            _userSkillRepository = userSkillRepository;
        }
        public  Task<List<UserSkill>> GetAllUserSkill()
        {
            return  _userSkillRepository.GetAllUserSkill();

        }

        public Task<UserSkill> GetUserSkillById(int id)
        {
            return  _userSkillRepository.GetUserSkillById(id);

        }

        public Task CreateUserSkill(UserSkill userSkill)
        {
            return _userSkillRepository.CreateUserSkill(userSkill);

        }

        public Task UpdateUserSkill(UserSkill userSkill)
        {
            return _userSkillRepository.UpdateUserSkill(userSkill);
        }

        public Task DeleteUserSkill(int id)
        {
            return _userSkillRepository.DeleteUserSkill(id);
        }
    }
}
