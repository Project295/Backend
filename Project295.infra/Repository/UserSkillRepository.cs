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
    public class UserSkillRepository: IUserSkillRepository
    {
        private readonly AppDbContext _dbContext;

        public UserSkillRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UserSkill>> GetAllUserSkill()
        {
            return await _dbContext.UserSkills.ToListAsync();

        }

        public async Task<UserSkill> GetUserSkillById(int id)
        {
            return await _dbContext.UserSkills.FirstOrDefaultAsync(x=>x.UserSkillId == id);

        }

        public async Task CreateUserSkill(UserSkill userSkill)
        {
             await _dbContext.AddAsync(userSkill);
             await _dbContext.SaveChangesAsync();

        }

        public async Task UpdateUserSkill(UserSkill userSkill)
        {
             _dbContext.Update(userSkill);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserSkill(int id)
        {
           var userSkill= await _dbContext.UserSkills.FirstOrDefaultAsync(x=>x.UserSkillId==id);
            _dbContext.Remove(userSkill);
            await _dbContext.SaveChangesAsync();
        }
    }
}
