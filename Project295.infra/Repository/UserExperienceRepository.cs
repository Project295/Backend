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
    public class UserExperienceRepository: IUserExperienceRepository
    {
        private readonly AppDbContext _dbContext;

        public UserExperienceRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UserExperience>> GetAllUserExperience()
        {
            return await _dbContext.UserExperiences.ToListAsync();

        }

        public async Task<UserExperience> GetUserExperienceById(int id)
        {
            return await _dbContext.UserExperiences.FirstOrDefaultAsync(x => x.UserExperienceId == id);


        }

        public async Task CreateUserExperience(UserExperience userExperience)
        {
            _dbContext.UserExperiences.Add(userExperience);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserExperience(UserExperience userExperience)
        {
            _dbContext.UserExperiences.Update(userExperience);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserExperience(int id)
        {
            var userExperience = await _dbContext.UserExperiences.FirstOrDefaultAsync(x => x.UserExperienceId == id);
            if (userExperience != null)
            {
                _dbContext.Remove(userExperience);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
