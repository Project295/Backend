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
        public List<ContactU> GetAllContactus()
        {
            return null;

        }

        public ContactU GetContactusById(int id)
        {
            return null;

        }

        public void CreateContactus(ContactU contactU)
        {

        }

        public void UpdateContactus(ContactU contactU)
        {

        }

        public void DeleteContactus(int id)
        {

        }
    }
}
