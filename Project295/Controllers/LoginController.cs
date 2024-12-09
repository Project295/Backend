using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServices _loginServices;
        public LoginController(ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }
        [HttpGet]
        public Task<List<Login>> GetAllLogins()
        {
            return _loginServices.GetAllLogins();

        }
        [HttpGet]
        [Route("GetLoginById")]
        public Task<Login> GetLoginById(int id)
        {
            return _loginServices.GetLoginById(id);
        }
        [HttpPost]
        [Route("CreateLogin")]
        public Task CreateLogin(Login login)
        {
            return _loginServices.CreateLogin(login);
        }
        [HttpPut]
        [Route("UpdateLogin")]
        public Task UpdateLogin(Login login)
        {
            return _loginServices.UpdateLogin(login);
        }
        [HttpDelete]
        [Route("DeleteLogin")]
        public Task DeleteLogin(int id)
        {
            return _loginServices.DeleteLogin(id);
        }

    }
}
