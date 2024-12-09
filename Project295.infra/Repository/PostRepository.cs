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
    public class PostRepository: IPostRepository
    {
        private readonly AppDbContext _dbContext;

        public PostRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Post>> GetAllPosts()
        {
            return await _dbContext.Posts.ToListAsync();

        }
        public async Task<Post> GetPostById(int id)
        {
            return await _dbContext.Posts.FirstOrDefaultAsync(x => x.PostId == id);

        }
        public async Task CreatePost(Post post)
        {
            _dbContext.Posts.Add(post);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdatePost(Post post)
        {
            _dbContext.Posts.Update(post);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeletePost(int id)
        {
            var post = await _dbContext.Posts.FirstOrDefaultAsync(x => x.PostId == id);
            if (post != null)
            {
                _dbContext.Remove(post);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
