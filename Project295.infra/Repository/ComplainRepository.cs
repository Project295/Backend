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
    public class ComplainRepository : IComplainRepository
    {
        private readonly AppDbContext _dbContext;

        public ComplainRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Complain>> GetAllComplain()
        {
            return await _dbContext.Complains.ToListAsync();
        }

        public async Task<Complain> GetComplainById(int id)
        {
            return await _dbContext.Complains.FirstOrDefaultAsync(x => x.ComplainId == id);

        }

        public async Task CreateComplain(Complain complain)
        {
            _dbContext.Complains.Add(complain);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateComplain(Complain complain)
        {
            _dbContext.Complains.Update(complain);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteComplain(int id)
        {
            var complain = await _dbContext.Complains.FirstOrDefaultAsync(x => x.ComplainId == id);
            if (complain != null)
            {
                _dbContext.Remove(complain);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
