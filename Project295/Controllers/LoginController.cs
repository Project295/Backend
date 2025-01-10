using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [Route("GetLoginById")]
        public string GetLoginById()
        {
            // return _dbContext.Login.FirstOrDefault(x=>x.LoginId==id);
            return "1111";
        }
        [HttpPost("Register")]
        public async Task Register(RegisterDTO registerDTO)
        {
            User user = new User()
            {
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                PhoneNumber = registerDTO.mobileNumber,
                IsBlocked = false,
                CreatedAt = DateTime.Now

            };
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

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
        [HttpPut]
        [Route("UpdateLogin")]
        public void UpdateLogin(Login login)
        {
             _dbContext.Login.Update(login);
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
