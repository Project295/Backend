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

            // Ensure that the UserId and IsBlocked properties are present and valid
            if (user.UserId <= 0)
            {
                throw new ArgumentException("Invalid UserId.");
            }

            // Check if the user with the given UserId exists
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.UserId == user.UserId);
            if (existingUser == null)
            {
                throw new KeyNotFoundException($"User with UserId {user.UserId} not found.");
            }

            existingUser.IsBlocked = user.IsBlocked;

            // Save changes to the database
            _dbContext.SaveChanges();
        }



    }
}
