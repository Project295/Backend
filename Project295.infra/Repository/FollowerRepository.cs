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
    public class FollowerRepository: IFollowerRepository
    {
        private readonly AppDbContext _dbContext;

        public FollowerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Follower>> GetAllFollowers()
        {
            return await _dbContext.Followers.ToListAsync();
        }
        public async Task<Follower> GetFollowerById(int id)
        {
            return await _dbContext.Followers.FirstOrDefaultAsync(x => x.UserId == id);

        }
        public async Task CreateFollower(Follower follower)
        {
            _dbContext.Followers.Add(follower);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateFollower(Follower follower)
        {
            _dbContext.Followers.Update(follower);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteFollower(int id)
        {
            var follower = await _dbContext.Followers.FirstOrDefaultAsync(x => x.UserId == id);
            if (follower != null)
            {
                _dbContext.Remove(follower);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
