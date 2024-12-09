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
    public class SkillRepository: ISkillRepository
    {
        private readonly AppDbContext _dbContext;

        public SkillRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Skill>> GetAllSkills()
        {
            return await _dbContext.Skills.ToListAsync();

        }

        public async Task<Skill>GetSkillById(int id)
        {
            return await _dbContext.Skills.FirstOrDefaultAsync(x => x.SkillId == id);

        }

        public async Task CreateSkill(Skill skill)
        {
            _dbContext.Skills.Add(skill);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSkill(Skill skill)
        {
            _dbContext.Skills.Update(skill);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteSkill(int id)
        {
            var skill = await _dbContext.Skills.FirstOrDefaultAsync(x => x.SkillId == id);
            if (skill != null)
            {
                _dbContext.Remove(skill);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
