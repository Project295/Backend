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
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public LoginController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Login> GetAllLogin()
        {
            return _dbContext.Login.ToList();

        }
        [HttpGet]
        [Route("Login")]
        public IActionResult Login([FromQuery]LoginDTO loginDTO)
        {
            var user = _dbContext.Users.Include(l=>l.Logins).FirstOrDefault(x=>x.Logins.Password  ==loginDTO.Password && x.Logins.UserName == loginDTO.UserName);
            if (user == null)
            {
                return Unauthorized(new { Message = "Invalid username or password" });
            }
            if(user.IsBlocked == true)
            {
                return Unauthorized(new { Message = "User is Blocked" });

            }

            return Ok(new { Message = "Login successful", UserId = user.UserId, RoleId=user.Logins.RoleId });
        }
        [HttpPost("Register")]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            bool isUserExist = _dbContext.Login.Any(x=>x.UserName == registerDTO.Email);

            if (isUserExist)
            {
                return BadRequest(new { message = "User already exists" });
            }
            else
            {
                User user = new User()
                {
                    FirstName = registerDTO.FirstName,
                    LastName = registerDTO.LastName,
                    PhoneNumber = registerDTO.mobileNumber,
                    IsBlocked = false,
                    CreatedAt = DateTime.Now

                };
                 _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                Login login = new Login()
                {
                    Password = registerDTO.Password,
                    UserName = registerDTO.Email,
                    RoleId = 2,
                    UserId = user.UserId
                };
                _dbContext.Login.Add(login);
                _dbContext.SaveChanges();
            }
            return Ok(new { message = "User added successfully" });
        }
        [HttpPut]
        [Route("UpdatePassword")]
        public IActionResult UpdateLogin([FromBody] UpdatePasswordDTO updatePasswordDTO)
        {
            var login = _dbContext.Login.FirstOrDefault(x=>x.UserId == updatePasswordDTO.UserId);
            if(login.Password != updatePasswordDTO.OldPassword)
            {
                return BadRequest();
            }
          
                login.Password = updatePasswordDTO.NewPassword;
            

             _dbContext.Login.Update(login);

             _dbContext.SaveChanges();

            return Ok();

        }
        [HttpDelete]
        [Route("DeleteLogin")]
        public void DeleteLogin(int id)
        {
            var login = _dbContext.Login.FirstOrDefault(x => x.LoginId == id);
            _dbContext.Login.Remove(login);
        }

    }
}
