using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public PostController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Post> GetAllPosts()
        {
            return _dbContext.Posts.ToList();

        }
        [HttpGet]
        [Route("GetPostById")]
        public Post GetPostById(int id)
        {
            return _dbContext.Posts.FirstOrDefault(x => x.PostId == id);

        }
        [HttpPost]
        [Route("CreatePost")]
        public void CreatePost(Post post)
        {
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();

        }
        [HttpPut]
        [Route("UpdatePost")]
        public void UpdatePost(Post post)
        {
            _dbContext.Posts.Update(post);
        }
        [HttpDelete]
        [Route("DeletePost")]
        public void DeletePost(int id)
        {
            var post = _dbContext.Posts.FirstOrDefault(x => x.PostId == id);
            _dbContext.Posts.Remove(post);

        }
    }
}
