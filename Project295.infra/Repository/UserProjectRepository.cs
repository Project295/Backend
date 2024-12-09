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
    public class UserProjectRepository: IUserProjectRepository
    {
        private readonly IDbContext _dbContext;

        public UserProjectRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
