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
    public class PostStatusRepository: IPostStatusRepository
    {
        private readonly IDbContext _dbContext;

        public PostStatusRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<PostStatus> GetAllPostStatus()
        {
            return null;

        }

        public PostStatus GetPostStatusById(int id)
        {
            return null;

        }

        public void CreatePostStatus(PostStatus postStatus)
        {

        }

        public void UpdatePostStatus(PostStatus postStatus)
        {

        }

        public void DeletePostStatus(int id)
        {

        }
    }
}
