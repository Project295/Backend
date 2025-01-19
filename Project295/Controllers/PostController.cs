using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project295.API.Common;
using Project295.API.DTO;
using Project295.API.Models;
using Project295.API.Service;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly UploadAttachmentService _uploadAttachmentService;
        public PostController(AppDbContext dbContext, UploadAttachmentService uploadAttachmentService)
        {
            _dbContext = dbContext;
            _uploadAttachmentService = uploadAttachmentService;
        }
        [HttpGet]
        public IActionResult GetAllPosts()
        {
            //public string? contant { get; set; }
            //public DateTime? createdAt { get; set; }
            //public string? postAttachmentPath { get; set; }
            //public string? userAttachmentPath { get; set; }
            //public int? userId { get; set; }
            //public string? FirstName { get; set; }
            //public string? LastName { get; set; }
            //public string? UserName { get; set; }
            var attachmentType = _dbContext.AttachmentTypes.ToList();
            int postImageTypeId = attachmentType.Find(x => x.AttachmentTypeName.ToLower().Contains("post")).AttachmentTypeId;
            int personalImageTypeId = attachmentType.Find(x => x.AttachmentTypeName.ToLower().Contains("personal")).AttachmentTypeId;

            var homePosts = _dbContext.Posts
                  .Where(x => x.IsBlocked == false)
                  .Include(u => u.User)
                  .ThenInclude(l => l.Logins)
                  .Include(a => a.Attachments)
                  .Select(post => new HomePostDTO
                  {
                      PostId = post.PostId,
                      PostStatusId = post.PostStatusId,
                      CategoryId = post.CategoryId,
                      Contant = post.Contant,
                      CreatedAt = post.CreatedAt,
                      PostAttachmentPath = post.Attachments.AttachmentTypeId==postImageTypeId? post.Attachments.AttachmentPath:null,
                      UserId = post.UserId,
                      UserName = post.User.Logins.UserName,
                      FirstName = post.User.FirstName,
                      LastName = post.User.LastName,
                      UserAttachmentPath = post.User.Attachments
                        .Where(a => a.AttachmentTypeId == personalImageTypeId)
                        .Select(a => a.AttachmentPath)
                        .FirstOrDefault() ?? "https://localhost:7011/attachment/default-profile.jpg"


                  }).ToList();

            return Ok(homePosts);

        }
        [HttpGet]
        [Route("GetPostById")]
        public Post GetPostById(int id)
        {
            return _dbContext.Posts.FirstOrDefault(x => x.PostId == id);

        }
        [HttpGet]
        [Route("GetAllUserPosts")]
        public IActionResult GetAllUserPosts([FromQuery]int userId)
        {
           var userPosts= _dbContext.Posts.Include(a=>a.Attachments)
                .Where(x => x.UserId == userId && x.IsBlocked==false)
                .Select(userPosts => new UserPostsDTO()
                {
                    PostId = userPosts.PostId,
                    Contant = userPosts.Contant,
                    CreatedAt = userPosts.CreatedAt,
                    CategoryId = userPosts.CategoryId,
                    PostStatusId = userPosts.PostStatusId,
                    AttachmentId = userPosts.Attachments.AttachmentId,
                    AttachmentPath = userPosts.Attachments.AttachmentPath
                });

            return Ok(new { Posts = userPosts , PostsCounts=userPosts.Count() });

        }
        [HttpPost]
        [Route("AddPost")]
        public IActionResult CreatePost([FromForm]AddPostDTO addPostDTO)
        {
           var post = new Post();
            post.UserId = addPostDTO.UserId;
            post.Contant = addPostDTO.Contant;
            post.CategoryId = addPostDTO.CategoryId;
            post.PostStatusId = addPostDTO.PostStatusId;
            post.CreatedAt = DateTime.Now;
            post.IsBlocked =false;
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
            if(addPostDTO.Attachment is not null)
            {
                var attachment = new Attachment();

                attachment.UserId = addPostDTO.UserId;
                attachment.PostId = post.PostId;
                attachment.AttachmentPath = _uploadAttachmentService.UploadImage(addPostDTO.Attachment);
                attachment.AttachmentTypeId = 4;
                attachment.CreatedAt = DateTime.Now;
                _dbContext.Attachments.Add(attachment);
                _dbContext.SaveChanges();
            }

            return Ok();
        }
        [HttpPut]
        [Route("UpdatePost")]
        public IActionResult UpdatePost([FromForm] UpdatePostDTO updatePostDTO)
        {
            var post = _dbContext.Posts.FirstOrDefault(x => x.PostId == updatePostDTO.PostId);
            post.Contant = updatePostDTO.Contant;
            post.CreatedAt = DateTime.Now;
            post.PostStatusId = updatePostDTO.PostStatusId;
            post.CategoryId = updatePostDTO.CategoryId;
            _dbContext.Posts.Update(post);

            if (updatePostDTO.Attachment is not null ||(updatePostDTO.AttachmentId is not null && updatePostDTO.AttachmentPath is null))
            {
                var attachment = new Attachment();
                attachment = _dbContext.Attachments.FirstOrDefault(x => x.PostId == updatePostDTO.PostId);
                attachment.AttachmentPath = updatePostDTO.Attachment is not null ? _uploadAttachmentService.UploadImage(updatePostDTO.Attachment):null;
                attachment.CreatedAt = DateTime.Now;
                _dbContext.Attachments.Update(attachment);
                
            }
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("DeletePost")]
        public IActionResult DeletePost([FromQuery]int postId)
        {
            var post = _dbContext.Posts.FirstOrDefault(x => x.PostId == postId);
            if(post != null)
            {
                _dbContext.Posts.Remove(post);
                _dbContext.SaveChanges();
                return Ok(new { Message = "Post deleted successfully" });
            }

            return BadRequest("Post not found");


        }
    }
}
