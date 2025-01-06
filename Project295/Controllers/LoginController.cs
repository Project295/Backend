using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
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
        public List<Login> GetAllLogins()
        {
            return _dbContext.Logins.ToList();

        }
        [HttpGet]
        [Route("GetLoginById")]
        public Login GetLoginById(int id)
        {
            return _dbContext.Logins.FirstOrDefault(x=>x.LoginId==id);
        }
        [HttpPost]
        [Route("CreateLogin")]
        public void CreateLogin(Login login)
        {
             _dbContext.Logins.Add(login);
        }
        [HttpPut]
        [Route("UpdateLogin")]
        public void UpdateLogin(Login login)
        {
             _dbContext.Logins.Update(login);
        }
        [HttpDelete]
        [Route("DeleteLogin")]
        public void DeleteLogin(int id)
        {
            var login = _dbContext.Logins.FirstOrDefault(x => x.LoginId == id);
            _dbContext.Logins.Remove(login);
        }

    }
}
