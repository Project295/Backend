using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostServices _postServices;
        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
        }
        [HttpGet]
        public Task<List<Post>> GetAllPosts()
        {
            return _postServices.GetAllPosts();

        }
        [HttpGet]
        [Route("GetPostById")]
        public Task<Post> GetPostById(int id)
        {
            return _postServices.GetPostById(id);

        }
        [HttpPost]
        [Route("CreatePost")]
        public Task CreatePost(Post post)
        {
            return _postServices.CreatePost(post);
        }
        [HttpPut]
        [Route("UpdatePost")]
        public Task UpdatePost(Post post)
        {
            return _postServices.UpdatePost(post);
        }
        [HttpDelete]
        [Route("DeletePost")]
        public Task DeletePost(int id)
        {
            return _postServices.DeletePost(id);
        }
    }
}
