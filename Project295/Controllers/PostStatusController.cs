using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostStatusController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public PostStatusController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<PostStatus> GetAllPostStatus()
        {
            return _dbContext.PostStatuses.ToList();

        }
        [HttpGet]
        [Route("GetPostStatusById")]
        public PostStatus GetPostStatusById(int id)
        {
            return _dbContext.PostStatuses.FirstOrDefault(x => x.PostStatusId == id);

        }
        [HttpPost]
        [Route("CreatePostStatus")]
        public void CreatePostStatus(PostStatus postStatus)
        {
            _dbContext.PostStatuses.Add(postStatus);
        }
        [HttpPut]
        [Route("UpdatePostStatus")]
        public void UpdatePostStatus(PostStatus postStatus)
        {
            _dbContext.PostStatuses.Update(postStatus);
        }
        [HttpDelete]
        [Route("DeletePostStatus")]
        public void DeletePostStatus(int id)
        {
            var postStatus = _dbContext.PostStatuses.FirstOrDefault(x => x.PostStatusId == id);
            _dbContext.PostStatuses.Remove(postStatus);

        }
    }
}
