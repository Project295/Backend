using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Services
{
    public class PostStatusServices: IPostStatusServices
    {
        private readonly IPostStatusRepository _postStatusRepository;
        public PostStatusServices(IPostStatusRepository postStatusRepository)
        {
            _postStatusRepository = postStatusRepository;
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
