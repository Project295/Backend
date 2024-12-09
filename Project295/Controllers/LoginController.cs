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
        public List<Login> GetAllLogins()
        {
            return null;

        }
        [HttpGet]
        [Route("GetLoginById")]
        public Login GetLoginById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateLogin")]
        public void CreateLogin(Login login)
        {

        }
        [HttpPut]
        [Route("UpdateLogin")]
        public void UpdateLogin(Login login)
        {

        }
        [HttpDelete]
        [Route("DeleteLogin")]
        public void DeleteLogin(int id)
        {

        }

    }
}
