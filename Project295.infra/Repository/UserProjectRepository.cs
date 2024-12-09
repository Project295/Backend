using Microsoft.EntityFrameworkCore;
using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using Project295.Infra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class UserProjectRepository: IUserProjectRepository
    {
        private readonly AppDbContext _dbContext;

        public UserProjectRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UserProject>> GetAllUserProject()
        {
            return await _dbContext.UserProjects.ToListAsync();

        }

        public async Task<UserProject> GetUserProjectById(int id)
        {
            return await _dbContext.UserProjects.FirstOrDefaultAsync(x=>x.UserProjectId==id);

        }

        public async Task CreateUserProject(UserProject userProject)
        {
           await _dbContext.UserProjects.AddAsync(userProject);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserProject(UserProject userProject)
        {
            _dbContext.UserProjects.Update(userProject);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserProject(int id)
        {
            var userProject = await _dbContext.UserProjects.FirstOrDefaultAsync(x => x.UserProjectId == id);
            if (userProject != null)
            {
                 _dbContext.UserProjects.Remove(userProject);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
