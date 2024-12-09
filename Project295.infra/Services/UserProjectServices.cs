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
    public class UserProjectServices: IUserProjectServices
    {
        private readonly IUserProjectRepository _userProjectRepository;
        public UserProjectServices(IUserProjectRepository userProjectRepository)
        {
            _userProjectRepository = userProjectRepository;
        }
        public Task<List<UserProject>> GetAllUserProject()
        {
            return _userProjectRepository.GetAllUserProject();

        }

        public Task<UserProject> GetUserProjectById(int id)
        {
            return _userProjectRepository.GetUserProjectById(id);

        }

        public Task CreateUserProject(UserProject userProject)
        {
            return _userProjectRepository.CreateUserProject(userProject);
        }

        public Task UpdateUserProject(UserProject userProject)
        {
            return _userProjectRepository.UpdateUserProject(userProject);
        }

        public Task DeleteUserProject(int id)
        {
            return _userProjectRepository.DeleteUserProject(id);
        }
    }
}
