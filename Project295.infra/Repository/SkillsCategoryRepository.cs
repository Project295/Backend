using Microsoft.EntityFrameworkCore;
using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using Project295.Core.Services;
using Project295.Infra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class SkillsCategoryRepository: ISkillsCategoryRepository
    {
        private readonly AppDbContext _dbContext;

        public SkillsCategoryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<SkillsCategory>> GetAllSkillsCategory()
        {
            return await _dbContext.SkillsCategories.ToListAsync();


        }

        public async Task<SkillsCategory> GetSkillsCategoryById(int id)
        {
            return await _dbContext.SkillsCategories.FirstOrDefaultAsync(x => x.SkillsCategoryId == id);

        }

        public async Task CreateSkillsCategory(SkillsCategory skillsCategory)
        {
            _dbContext.SkillsCategories.Add(skillsCategory);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSkillsCategory(SkillsCategory skillsCategory)
        {
            _dbContext.SkillsCategories.Update(skillsCategory);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteSkillsCategory(int id)
        {
            var skillsCategory = await _dbContext.SkillsCategories.FirstOrDefaultAsync(x => x.SkillsCategoryId == id);
            if (skillsCategory != null)
            {
                _dbContext.Remove(skillsCategory);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
