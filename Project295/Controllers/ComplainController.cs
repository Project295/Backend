using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project295.API.Common;
using Project295.API.DTO;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public ComplainController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<ComplainDTO> GetAllComplain()
        {
            var complaints = _dbContext.Complains
                .Include(c => c.Post)
                .Include(c => c.User) 
                .Include(c => c.Complainant) 
                .Where(c => c.Post != null && c.User != null && c.Complainant != null) 
                .Select(c => new ComplainDTO
                {
                    ComplainId = c.ComplainId,
                    ComplainDiscription = c.ComplainDiscription,
                    CreatedAt = c.CreatedAt,
                    IsActive = c.IsActive,

                    ComplainantId = c.Complainant.UserId,
                    ComplainantFirstName = c.Complainant.FirstName,
                    ComplainantLastName = c.Complainant.LastName,

                    PostId = c.Post.PostId,
                    Contant = c.Post.Contant,
                    IsBlocked = c.Post.IsBlocked,

                    UserId = c.User.UserId,
                    FirstName = c.User.FirstName,
                    LastName = c.User.LastName
                }).ToList();

            return complaints;
        }

        [HttpGet]
        [Route("GetComplainById")]
        public Complain GetComplainById(int id)
        {
            return _dbContext.Complains.FirstOrDefault(x=>x.ComplainId == id);
        }
        [HttpPost]
        [Route("CreateComplain")]
        public IActionResult CreateComplain([FromQuery] string complaintDescription, [FromQuery] int postId, [FromQuery] int userId)
        {
            var complain = new Complain()
            {
                ComplainDiscription = complaintDescription,
                PostId = postId,
                UserId = userId,
                CreatedAt = DateTime.Now
            };
            _dbContext.Complains.Add(complain);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpPut]
        [Route("UpdateComplain")]
        public void UpdateComplain(Complain complain)
        {
            _dbContext.Complains.Update(complain);
            _dbContext.SaveChanges();

        }
        [HttpDelete]
        [Route("DeleteComplain/{id}")]
        public void DeleteComplain(int id)
        {
            var complain = _dbContext.Complains.FirstOrDefault(x => x.ComplainId == id);
            _dbContext.Complains.Remove(complain);
            _dbContext.SaveChanges();

        }
        [HttpPut]
        [Route("UpdateComplainStatus")]
        public void UpdateComplainStatus(Post post)
        {
            var existingPost = _dbContext.Posts.FirstOrDefault(c => c.PostId == post.PostId);

            if (existingPost != null)
            {
                existingPost.IsBlocked = post.IsBlocked; 
                _dbContext.SaveChanges(); 
            }

        }
    }
}
