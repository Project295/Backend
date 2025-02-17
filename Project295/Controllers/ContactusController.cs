﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.DTO;
using Project295.API.Models;
using System.Diagnostics.Contracts;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactusController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public ContactusController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<ContactU> GetAllContactus()
        {
            return _dbContext.ContactUs.ToList();

        }
        [HttpGet]
        [Route("GetUserById")]
        public ContactU GetContactusById(int id)
        {
            return _dbContext.ContactUs.FirstOrDefault(x => x.ContactUsId == id);

        }
        [HttpPost]
        [Route("CreateContactus")]
        public IActionResult CreateContactus([FromBody] ContactUsDto contactData)
        {
            var contact = new ContactU()
            {
                Name = contactData.Name,
                Email = contactData.Email,
                Message = contactData.Message
            };
             _dbContext.ContactUs.Add(contact);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpPut]
        [Route("UpdateContactus")]
        public void UpdateContactus(ContactU contactU)
        {
            _dbContext.ContactUs.Update(contactU);
            _dbContext.SaveChanges();

        }
        [HttpDelete]
        [Route("DeleteContactus/{id}")]
        public void DeleteContactus(int id)
        {
            var contact = _dbContext.ContactUs.FirstOrDefault(x => x.ContactUsId == id);
            _dbContext.ContactUs.Remove(contact);
            _dbContext.SaveChanges();

        }
    }
}
