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
        public List<Post> GetAllPosts()
        {
            return null;

        }
        [HttpGet]
        [Route("GetPostById")]
        public Post GetPostById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreatePost")]
        public void CreatePost(Post post)
        {

        }
        [HttpPut]
        [Route("UpdatePost")]
        public void UpdatePost(Post post)
        {

        }
        [HttpDelete]
        [Route("DeletePost")]
        public void DeletePost(int id)
        {

        }
    }
}
