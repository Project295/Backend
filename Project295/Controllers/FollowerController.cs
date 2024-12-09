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
        public List<Follower> GetAllFollowers()
        {
            return null;
        }

        [HttpGet]
        [Route("GetFollowerById")]
        public Follower GetFollowerById(int id)
        {
            return null;

        }

        [HttpPost]
        [Route("CreateFollower")]
        public void CreateFollower(Follower follower)
        {

        }

        [HttpPut]
        [Route("UpdateFollower")]
        public void UpdateFollower(Follower follower)
        {

        }

        [HttpDelete]
        [Route("DeleteFollower")]
        public void DeleteFollower(int id)
        {

        }
    }
}
