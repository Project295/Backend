using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;


namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProjectController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public UserProjectController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<UserProject> GetAllUserProject()
        {
            return _dbContext.UserProjects.ToList();

        }
        [HttpGet]
        [Route("GetUserProjectById")]
        public UserProject GetUserProjectById(int id)
        {
            return _dbContext.UserProjects.FirstOrDefault(x=>x.UserProjectId==id);

        }
        [HttpPost]
        [Route("CreateUserProject")]
        public void CreateUserProject(UserProject userProject)
        {
            _dbContext.UserProjects.Add(userProject);       
        }
        [HttpPut]
        [Route("UpdateUserProject")]
        public void UpdateUserProject(UserProject userProject)
        {
            _dbContext.UserProjects.Update(userProject);
        }
        [HttpDelete]
        [Route("DeleteUserProject")]
        public void DeleteUserProject(int id)
        {
            var userProject = _dbContext.UserProjects.FirstOrDefault(x => x.UserProjectId == id);
            _dbContext.UserProjects.Remove(userProject);
        }
    }
}
