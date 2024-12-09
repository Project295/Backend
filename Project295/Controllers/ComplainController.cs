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
        public List<Complain> GetAllComplain()
        {
            return null;

        }
        [HttpGet]
        [Route("GetComplainById")]
        public Complain GetComplainById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateComplain")]
        public void CreateComplain(Complain complain)
        {

        }
        [HttpPut]
        [Route("UpdateComplain")]
        public void UpdateComplain(Complain complain)
        {

        }
        [HttpDelete]
        [Route("DeleteComplain")]
        public void DeleteComplain(int id)
        {

        }
    }
}
