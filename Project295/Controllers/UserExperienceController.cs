using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.DTO;
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
        [Route("GetUserExperienceById/{userId}")]
        public  IActionResult GetUserExperienceById(int userId)
        {
            var UserExperience = _dbContext.UserExperiences
                .Where(x=>x.UserId== userId && x.UserExperienceTitle!=null)
                .Select(Experience => new GetUserExperienceDTO()
                {
                    UserExperienceId = Experience.UserExperienceId,
                    UserExperienceTitle = Experience.UserExperienceTitle,
                    UserExperienceDiscription = Experience.UserExperienceDiscription,
                    UserExperienceDateFrom = Experience.UserExperienceDateFrom,
                    UserExperienceDateTo = Experience.UserExperienceDateTo,
                    UserId = Experience.UserId,
                    CreatedAt = Experience.CreatedAt

                }).ToList();

            return Ok(UserExperience);
        }
        [HttpPost]
        [Route("CreateUserExperience")]
        public  IActionResult CreateUserExperience(AddUserExperienceDTO addUserExperienceDTO)
        {
            var userExperience = new UserExperience()
            {
                UserExperienceTitle = addUserExperienceDTO.UserExperienceTitle,
                UserId = addUserExperienceDTO.UserId,
                UserExperienceDiscription = addUserExperienceDTO.UserExperienceDiscription,
                UserExperienceDateFrom = addUserExperienceDTO.UserExperienceDateFrom,
                UserExperienceDateTo = addUserExperienceDTO.UserExperienceDateTo,
                CreatedAt = DateTime.Now
            };
             _dbContext.UserExperiences.Add(userExperience);
            _dbContext.SaveChanges();
            return Ok(userExperience);
        }
        [HttpPut]
        [Route("UpdateUserExperience")]
        public IActionResult UpdateUserExperience(UpdateUserExperienceDTO updateUserExperienceDTO)
        {

            var userExperience = _dbContext.UserExperiences
                 .FirstOrDefault(x => x.UserExperienceId == updateUserExperienceDTO.UserExperienceId);
            userExperience.UserExperienceTitle = updateUserExperienceDTO?.UserExperienceTitle;
            userExperience.UserExperienceDiscription = updateUserExperienceDTO?.UserExperienceDiscription;
            userExperience.UserExperienceDateFrom = updateUserExperienceDTO?.UserExperienceDateFrom;
            userExperience.UserExperienceDateTo = updateUserExperienceDTO?.UserExperienceDateTo;

                
                _dbContext.UserExperiences.Update(userExperience);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteUserExperience/{userExperienceId}")]
        public IActionResult DeleteUserExperience(int userExperienceId)
        {
            var userExperience = _dbContext.UserExperiences.FirstOrDefault(x => x.UserExperienceId == userExperienceId);
            _dbContext.UserExperiences.Remove(userExperience);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("GetUserEducationById/{userId}")]
        public IActionResult GetUserEducationById(int userId)
        {
            var userEducation = _dbContext.UserExperiences
                .Where(x => x.UserId == userId && x.UniversityName !=null)
                .Select(Experience => new GetUserEducationDTO()
                {
                    UserExperienceId = Experience.UserExperienceId,
                    UniversityName = Experience.UniversityName,
                    CertificationName = Experience.CertificationName,
                    UserExperienceDateFrom = Experience.UserExperienceDateFrom,
                    UserExperienceDateTo = Experience.UserExperienceDateTo,
                    UserId = Experience.UserId,
                    CreatedAt = Experience.CreatedAt

                }).ToList();

            return Ok(userEducation);
        }
        [HttpPost]
        [Route("CreateUserEducation")]
        public IActionResult CreateUserEducation(AddUserEducationDTO addUserEducationDTO)
        {
            var userEducation = new UserExperience()
            {
                UniversityName = addUserEducationDTO.UniversityName,
                UserId = addUserEducationDTO.UserId,
                CertificationName = addUserEducationDTO.CertificationName,
                UserExperienceDateFrom = addUserEducationDTO.UserExperienceDateFrom,
                UserExperienceDateTo = addUserEducationDTO.UserExperienceDateTo,
                CreatedAt = DateTime.Now
            };
            _dbContext.UserExperiences.Add(userEducation);
            _dbContext.SaveChanges();
            return Ok(userEducation);
        }
        [HttpPut]
        [Route("UpdateUserEducation")]
        public IActionResult UpdateUserEducation(UpdateUserEducationDTO updateUserEducationDTO)
        {

            var userEducation = _dbContext.UserExperiences
                 .FirstOrDefault(x => x.UserExperienceId == updateUserEducationDTO.UserExperienceId);
            userEducation.CertificationName = updateUserEducationDTO?.CertificationName;
            userEducation.UniversityName = updateUserEducationDTO?.UniversityName;
            userEducation.UserExperienceDateFrom = updateUserEducationDTO?.UserExperienceDateFrom;
            userEducation.UserExperienceDateTo = updateUserEducationDTO?.UserExperienceDateTo;


            _dbContext.UserExperiences.Update(userEducation);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteUserEducation/{userExperienceId}")]
        public IActionResult DeleteUserEducation(int userExperienceId)
        {
            var userEducation = _dbContext.UserExperiences.FirstOrDefault(x => x.UserExperienceId == userExperienceId);
            _dbContext.UserExperiences.Remove(userEducation);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
