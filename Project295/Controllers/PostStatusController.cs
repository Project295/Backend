using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostStatusController : ControllerBase
    {
        private readonly IPostStatusServices _postStatusServices;
        public PostStatusController(IPostStatusServices postStatusServices)
        {
            _postStatusServices = postStatusServices;
        }
        [HttpGet]
        public Task<List<PostStatus>> GetAllPostStatus()
        {
            return _postStatusServices.GetAllPostStatus();

        }
        [HttpGet]
        [Route("GetPostStatusById")]
        public Task<PostStatus> GetPostStatusById(int id)
        {
            return _postStatusServices.GetPostStatusById(id);

        }
        [HttpPost]
        [Route("CreatePostStatus")]
        public Task CreatePostStatus(PostStatus postStatus)
        {
            return _postStatusServices.CreatePostStatus(postStatus);
        }
        [HttpPut]
        [Route("UpdatePostStatus")]
        public Task UpdatePostStatus(PostStatus postStatus)
        {
            return _postStatusServices.UpdatePostStatus(postStatus);
        }
        [HttpDelete]
        [Route("DeletePostStatus")]
        public Task DeletePostStatus(int id)
        {
            return _postStatusServices.DeletePostStatus(id);
        }
    }
}
