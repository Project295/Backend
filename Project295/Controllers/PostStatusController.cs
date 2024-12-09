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
        public List<PostStatus> GetAllPostStatus()
        {
            return null;

        }
        [HttpGet]
        [Route("GetPostStatusById")]
        public PostStatus GetPostStatusById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreatePostStatus")]
        public void CreatePostStatus(PostStatus postStatus)
        {

        }
        [HttpPut]
        [Route("UpdatePostStatus")]
        public void UpdatePostStatus(PostStatus postStatus)
        {

        }
        [HttpDelete]
        [Route("DeletePostStatus")]
        public void DeletePostStatus(int id)
        {

        }
    }
}
