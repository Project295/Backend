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
        public List<UserProject> GetAllUserProject()
        {
            return null;

        }

        public UserProject GetUserProjectById(int id)
        {
            return null;

        }

        public void CreateUserProject(UserProject userProject)
        {

        }

        public void UpdateUserProject(UserProject userProject)
        {

        }

        public void DeleteUserProject(int id)
        {

        }
    }
}
