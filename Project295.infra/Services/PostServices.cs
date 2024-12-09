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
