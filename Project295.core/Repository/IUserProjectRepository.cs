using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IUserProjectRepository
    {
        Task<List<UserProject>> GetAllUserProject();
        Task<UserProject> GetUserProjectById(int id);
        Task CreateUserProject(UserProject userProject);
        Task UpdateUserProject(UserProject userProject);
        Task DeleteUserProject(int id);
    }
}
