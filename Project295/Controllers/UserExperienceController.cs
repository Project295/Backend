using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;


namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserExperienceController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public UserExperienceController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public  List<UserExperience> GetAllUserExperience()
        {
            return _dbContext.UserExperiences.ToList();

        }
        [HttpGet]
        [Route("GetUserExperienceById")]
        public  UserExperience GetUserExperienceById(int id)
        {
            return _dbContext.UserExperiences.FirstOrDefault(x=>x.UserExperienceId==id);

        }
        [HttpPost]
        [Route("CreateUserExperience")]
        public  void CreateUserExperience(UserExperience userExperience)
        {
             _dbContext.UserExperiences.Add(userExperience);
        }
        [HttpPut]
        [Route("UpdateUserExperience")]
        public void UpdateUserExperience(UserExperience userExperience)
        {
            _dbContext.UserExperiences.Update(userExperience);
        }
        [HttpDelete]
        [Route("DeleteUserExperience")]
        public void DeleteUserExperience(int id)
        {
            var userExperience = _dbContext.UserExperiences.FirstOrDefault(x => x.UserExperienceId == id);
            _dbContext.UserExperiences.Remove(userExperience);
        }
    }
}
