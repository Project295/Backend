using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactusController : ControllerBase
    {
        private readonly IContactusServices _contactusServices;
        public ContactusController(IContactusServices contactusServices)
        {
            _contactusServices = contactusServices;
        }
        [HttpGet]
        public Task<List<ContactU>> GetAllContactus()
        {
            return _contactusServices.GetAllContactus();

        }
        [HttpGet]
        [Route("GetUserById")]
        public Task<ContactU> GetContactusById(int id)
        {
            return _contactusServices.GetContactusById(id);

        }
        [HttpPost]
        [Route("CreateContactus")]
        public Task CreateContactus(ContactU contactU)
        {
            return _contactusServices.CreateContactus(contactU);
        }
        [HttpPut]
        [Route("UpdateContactus")]
        public Task UpdateContactus(ContactU contactU)
        {
            return _contactusServices.UpdateContactus(contactU);
        }
        [HttpDelete]
        [Route("DeleteContactus")]
        public Task DeleteContactus(int id)
        {
            return _contactusServices.DeleteContactus(id);
        }
    }
}
