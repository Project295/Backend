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
    public class PostRepository: IPostRepository
    {
        private readonly IDbContext _dbContext;

        public PostRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Post> GetAllPosts()
        {
            return null;

        }
        public Post GetPostById(int id)
        {
            return null;

        }
        public void CreatePost(Post post)
        {

        }
        public void UpdatePost(Post post)
        {

        }
        public void DeletePost(int id)
        {

        }
    }
}
