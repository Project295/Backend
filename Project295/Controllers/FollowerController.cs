using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowerController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public FollowerController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Follower> GetAllFollowers()
        {
            return _dbContext.Followers.ToList();
        }

        [HttpGet]
        [Route("GetFollowerById")]
        public Follower GetFollowerById(int id)
        {
            return _dbContext.Followers.FirstOrDefault(x => x.FollowerId == id);

        }

        [HttpPost]
        [Route("CreateFollower")]
        public void CreateFollower(Follower follower)
        {
            _dbContext.Followers.Add(follower);
        }

        [HttpPut]
        [Route("UpdateFollower")]
        public void UpdateFollower(Follower follower)
        {
            _dbContext.Followers.Update(follower);
        }

        [HttpDelete]
        [Route("DeleteFollower")]
        public void DeleteFollower(int id)
        {
            var follower = _dbContext.Followers.FirstOrDefault(x => x.FollowerId == id);
            _dbContext.Followers.Remove(follower);
        }
    }
}
