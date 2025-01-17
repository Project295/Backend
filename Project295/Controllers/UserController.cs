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
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public UserController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();

        }
        [HttpGet]
        [Route("GetUserById")]
        public User GetUserById(int id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserId == id);

        }
        [HttpGet]
        [Route("GetUserProfile")]
        public IActionResult GetUserProfile([FromQuery]int userId)
        {
            try
            {
                var userProfile = _dbContext.Users
                          .Include(l => l.Logins)
                          .Include(a => a.Attachments)
                          .FirstOrDefault(x => x.UserId == userId);

                var attachmentType = _dbContext.AttachmentTypes.ToList();

                int profilePictureTypeId = attachmentType
                    .FirstOrDefault(x => x.AttachmentTypeName!.ToLower().Contains("personal"))!
                    .AttachmentTypeId;

                int profileHeaderTypeId = attachmentType
                    .FirstOrDefault(x => x.AttachmentTypeName!.ToLower().Contains("header"))!
                    .AttachmentTypeId;

                ProfileDTO profileDTO = new ProfileDTO()
                {
                    UserName = userProfile.Logins.UserName,
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                    PhoneNumber = userProfile.PhoneNumber,
                    PersonalImagePath = userProfile.Attachments.FirstOrDefault(x => x.AttachmentTypeId == profilePictureTypeId)?.AttachmentPath,
                    HeaderImagePath = userProfile.Attachments.FirstOrDefault(x => x.AttachmentTypeId == profileHeaderTypeId)?.AttachmentPath
                };
                if (profileDTO.PersonalImagePath == null)
                {
                    profileDTO.PersonalImagePath = "https://localhost:7011/wwwroot/attachment/default-profile.jpg";
                }
                else if (profileDTO.HeaderImagePath == null)
                {
                    profileDTO.HeaderImagePath = "https://localhost:7011/wwwroot/attachment/default-background.png";
                }

                return Ok(profileDTO);
            }
            catch
            {
                return BadRequest(new { message = "This profile is damaged! Please contact the admin." });
            }
        }
        [HttpGet]
        [Route("ProfileCounts")]
        public IActionResult ProfileCounts([FromQuery]int userId)
        {
            var counts = _dbContext.Users
                 .Where(x => x.UserId == userId)
                 .Select(count => new ProfileCountsDTO()
                 {
                   PostsCount = count.Posts.Count(),
                   FollowedsCount = count.FollowerFolloweds.Count(),
                   FollowerCount = count.FollowerUsers.Count()
                 })
                .FirstOrDefault();

            return Ok(counts);

        }
        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(User user)
        {
             _dbContext.Users.Add(user);
        }
        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateUser(User user)
        {
            _dbContext.Users.Update(user);

        }
        [HttpDelete]
        [Route("DeleteUser")]
        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
            _dbContext.Users.Remove(user);
        }
    }
}
