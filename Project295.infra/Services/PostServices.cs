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
    public class PostServices: IPostServices
    {
        private readonly IPostRepository _postRepository;
        public PostServices(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public Task<List<Post>> GetAllPosts()
        {
            return _postRepository.GetAllPosts();

        }
        public Task<Post> GetPostById(int id)
        {
            return _postRepository.GetPostById(id);

        }
        public Task CreatePost(Post post)
        {
            return _postRepository.CreatePost(post);
        }
        public Task UpdatePost(Post post)
        {
            return _postRepository.UpdatePost(post);
        }
        public Task DeletePost(int id)
        {
            return _postRepository.DeletePost(id);
        }
    }
}
