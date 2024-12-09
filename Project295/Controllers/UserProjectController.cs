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
        public Task<List<UserProject>> GetAllUserProject()
        {
            return _userProjectServices.GetAllUserProject();

        }
        [HttpGet]
        [Route("GetUserProjectById")]
        public Task<UserProject> GetUserProjectById(int id)
        {
            return _userProjectServices.GetUserProjectById(id);

        }
        [HttpPost]
        [Route("CreateUserProject")]
        public Task CreateUserProject(UserProject userProject)
        {
            return _userProjectServices.CreateUserProject(userProject);
        }
        [HttpPut]
        [Route("UpdateUserProject")]
        public Task UpdateUserProject(UserProject userProject)
        {
            return _userProjectServices.UpdateUserProject(userProject);
        }
        [HttpDelete]
        [Route("DeleteUserProject")]
        public Task DeleteUserProject(int id)
        {
            return _userProjectServices.DeleteUserProject(id);
        }
    }
}
