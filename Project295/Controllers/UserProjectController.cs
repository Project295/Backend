using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProjectController : ControllerBase
    {
        private readonly IUserProjectServices _userProjectServices;
        public UserProjectController(IUserProjectServices userProjectServices)
        {
            _userProjectServices = userProjectServices;
        }
        [HttpGet]
        public List<UserProject> GetAllUserProject()
        {
            return null;

        }
        [HttpGet]
        [Route("GetUserProjectById")]
        public UserProject GetUserProjectById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateUserProject")]
        public void CreateUserProject(UserProject userProject)
        {

        }
        [HttpPut]
        [Route("UpdateUserProject")]
        public void UpdateUserProject(UserProject userProject)
        {

        }
        [HttpDelete]
        [Route("DeleteUserProject")]
        public void DeleteUserProject(int id)
        {

        }
    }
}
