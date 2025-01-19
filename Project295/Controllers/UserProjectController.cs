using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.DTO;
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
        [Route("GetUserProjectById/{userId}")]
        public IActionResult GetUserProjectById(int userId)
        {
            var userProjects = _dbContext.UserProjects
                .Where(x => x.UserId == userId)
                .Select(userProject=> new UserProjectsDTO(){
                    UserProjectId = userProject.UserProjectId,
                    UserProjectsTitle = userProject.UserProjectsTitle,
                    UserProjectDiscription = userProject.UserProjectDiscription,
                    CreatedAt = userProject.CreatedAt,
                    UserId = userProject.UserId

                
                 }).ToList();

            return Ok(userProjects);

        }
        [HttpPost]
        [Route("CreateUserProject")]
        public IActionResult CreateUserProject([FromBody] AddUserProjectDTO userProjectDTO)
        {
            var userProject = new UserProject()
            {
                UserProjectsTitle = userProjectDTO.UserProjectsTitle,
                UserProjectDiscription = userProjectDTO.UserProjectDiscription,
                UserId = userProjectDTO.UserId,
                CreatedAt = DateTime.Now,

            };
            _dbContext.UserProjects.Add(userProject);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpPut]
        [Route("UpdateUserProject")]
        public IActionResult UpdateUserProject([FromBody]UpdateUserProjectDTO updateUserProjectDTO)
        {
            var userProject = _dbContext.UserProjects
                .FirstOrDefault(x => x.UserProjectId == updateUserProjectDTO.UserProjectId);
            userProject.UserProjectsTitle = updateUserProjectDTO.UserProjectsTitle;
            userProject.UserProjectDiscription = updateUserProjectDTO.UserProjectDiscription;
            _dbContext.UserProjects.Update(userProject);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteUserProject/{userProjectId}")]
        public IActionResult DeleteUserProject(int userProjectId)
        {
            var userProject = _dbContext.UserProjects.FirstOrDefault(x => x.UserProjectId == userProjectId);
            _dbContext.UserProjects.Remove(userProject);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
