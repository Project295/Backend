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
        public Task<List<PostStatus>> GetAllPostStatus()
        {
            return _postStatusRepository.GetAllPostStatus();

        }

        public Task<PostStatus> GetPostStatusById(int id)
        {
            return _postStatusRepository.GetPostStatusById(id);

        }

        public Task CreatePostStatus(PostStatus postStatus)
        {
            return _postStatusRepository.CreatePostStatus(postStatus);
        }

        public Task UpdatePostStatus(PostStatus postStatus)
        {
            return _postStatusRepository.UpdatePostStatus(postStatus);
        }

        public Task DeletePostStatus(int id)
        {
            return _postStatusRepository.DeletePostStatus(id);
        }
    }
}
