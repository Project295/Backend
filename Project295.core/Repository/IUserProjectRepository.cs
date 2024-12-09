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
         List<UserProject> GetAllUserProject();
         UserProject GetUserProjectById(int id);
         void CreateUserProject(UserProject userProject);
         void UpdateUserProject(UserProject userProject);
         void DeleteUserProject(int id);
    }
}
