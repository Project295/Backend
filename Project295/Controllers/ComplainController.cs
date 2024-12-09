using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : ControllerBase
    {
        private readonly IComplainServices _complainServices;
        public ComplainController(IComplainServices complainServices)
        {
            _complainServices = complainServices;
        }
        [HttpGet]
        public Task<List<Complain>> GetAllComplain()
        {
            return _complainServices.GetAllComplain();

        }
        [HttpGet]
        [Route("GetComplainById")]
        public Task<Complain> GetComplainById(int id)
        {
            return _complainServices.GetComplainById(id);
        }
        [HttpPost]
        [Route("CreateComplain")]
        public Task CreateComplain(Complain complain)
        {
            return _complainServices.UpdateComplain(complain);
        }
        [HttpPut]
        [Route("UpdateComplain")]
        public Task UpdateComplain(Complain complain)
        {
            return _complainServices.UpdateComplain(complain);
        }
        [HttpDelete]
        [Route("DeleteComplain")]
        public Task DeleteComplain(int id)
        {
            return _complainServices.DeleteComplain(id);
        }
    }
}
