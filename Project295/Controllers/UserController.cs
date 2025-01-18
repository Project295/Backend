﻿using Microsoft.AspNetCore.Http;
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
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly UploadAttachmentService _uploadAttachmentService;
        public UserController(AppDbContext dbContext, UploadAttachmentService uploadAttachmentService)
        {
            _dbContext = dbContext;
            _uploadAttachmentService = uploadAttachmentService;
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
                    HeaderImagePath = userProfile.Attachments.FirstOrDefault(x => x.AttachmentTypeId == profileHeaderTypeId)?.AttachmentPath,
                    Password = userProfile.Logins.Password
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
            _dbContext.SaveChanges();

        }
        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser([FromForm]UpdateUserDTO updateUserDTO)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.UserId == updateUserDTO.UserId);
            user.FirstName = updateUserDTO.FirstName;
            user.LastName = updateUserDTO.LastName;
            user.PhoneNumber = updateUserDTO.PhoneNumber;
            _dbContext.Users.Update(user);
            var login = _dbContext.Login.FirstOrDefault(x => x.UserId == updateUserDTO.UserId);
            login.Password = updateUserDTO.Password;
            login.UserName = updateUserDTO.UserName;
            _dbContext.Login.Update(login);
            if (updateUserDTO.image is not null)
            {
                var attachmenttype = _dbContext.AttachmentTypes.FirstOrDefault(x=>x.AttachmentTypeName.ToLower().Contains("personal"))!.AttachmentTypeId;
                var attachment = new Attachment();
                attachment = _dbContext.Attachments.FirstOrDefault(x => x.UserId == updateUserDTO.UserId && x.AttachmentTypeId==attachmenttype);
                attachment.AttachmentPath = updateUserDTO.image is not null ? _uploadAttachmentService.UploadImage(updateUserDTO.image) : attachment.AttachmentPath;
                attachment.CreatedAt = updateUserDTO.image is not null ? DateTime.Now: attachment.CreatedAt;
                attachment.UserId = updateUserDTO.UserId;
                _dbContext.Attachments.Update(attachment);
            }


            _dbContext.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();

        }
        [HttpGet("GetUsersData")]
        public IActionResult GetUsersData()
        {
            var usersData = _dbContext.Login
                .Include(l => l.User)
                .Include(l => l.Role)
                .Where(l => l.RoleId == l.Role.RoleId && l.UserId == l.User.UserId)
                .Select(l => new UsersDTO
                {
                    LoginId = l.LoginId,
                    UserName = l.UserName,
                    RoleId = l.RoleId,
                    RoleName = l.Role.RoleName,
                    UserId = l.User.UserId,
                    FirstName = l.User.FirstName,
                    LastName = l.User.LastName,
                    PhoneNumber = l.User.PhoneNumber,
                    IsBlocked = l.User.IsBlocked
                })
                .ToList();

            return Ok(usersData);
        }

        [HttpPut("BlockedUser")]
        public void BlockedUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("Invalid user data.");
            }

            if (user.UserId <= 0)
            {
                throw new ArgumentException("Invalid UserId.");
            }

            var existingUser = _dbContext.Users.FirstOrDefault(u => u.UserId == user.UserId);
            if (existingUser == null)
            {
                throw new KeyNotFoundException($"User with UserId {user.UserId} not found.");
            }

            existingUser.IsBlocked = user.IsBlocked;

            _dbContext.SaveChanges();
        }
    }
}
