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
    public class PostStatusRepository: IPostStatusRepository
    {
        private readonly AppDbContext _dbContext;

        public PostStatusRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<PostStatus>> GetAllPostStatus()
        {
            return await _dbContext.PostStatuses.ToListAsync();


        }

        public async Task<PostStatus> GetPostStatusById(int id)
        {
            return await _dbContext.PostStatuses.FirstOrDefaultAsync(x => x.PostStatusId == id);

        }

        public async Task CreatePostStatus(PostStatus postStatus)
        {
            _dbContext.PostStatuses.Add(postStatus);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdatePostStatus(PostStatus postStatus)
        {
            _dbContext.PostStatuses.Update(postStatus);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePostStatus(int id)
        {
            var postStatus = await _dbContext.PostStatuses.FirstOrDefaultAsync(x => x.PostStatusId == id);
            if (postStatus != null)
            {
                _dbContext.Remove(postStatus);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
