using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowerController : ControllerBase
    {
        private readonly IFollowerServices _followerServices;
        public FollowerController(IFollowerServices followerServices)
        {
            _followerServices = followerServices;
        }

        [HttpGet]
        public Task<List<Follower>> GetAllFollowers()
        {
            return _followerServices.GetAllFollowers();
        }

        [HttpGet]
        [Route("GetFollowerById")]
        public Task<Follower> GetFollowerById(int id)
        {
            return _followerServices.GetFollowerById(id);

        }

        [HttpPost]
        [Route("CreateFollower")]
        public Task CreateFollower(Follower follower)
        {
            return _followerServices.CreateFollower(follower);
        }

        [HttpPut]
        [Route("UpdateFollower")]
        public Task UpdateFollower(Follower follower)
        {
            return _followerServices.UpdateFollower(follower);
        }

        [HttpDelete]
        [Route("DeleteFollower")]
        public Task DeleteFollower(int id)
        {
            return _followerServices.DeleteFollower(id);
        }
    }
}
