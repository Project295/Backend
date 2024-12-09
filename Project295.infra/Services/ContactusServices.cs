using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Services
{
    public class ContactusServices : IContactusServices
    {
        private readonly IContactusRepository _contactusRepository;
        public ContactusServices(IContactusRepository contactusRepository)
        {
            _contactusRepository = contactusRepository;
        }
        public Task<List<ContactU>> GetAllContactus()
        {
            return _contactusRepository.GetAllContactus();

        }

        public Task<ContactU> GetContactusById(int id)
        {
            return _contactusRepository.GetContactusById(id);

        }

        public Task CreateContactus(ContactU contactU)
        {
            return _contactusRepository.CreateContactus(contactU);
        }

        public Task UpdateContactus(ContactU contactU)
        {
            return _contactusRepository.UpdateContactus(contactU);
        }

        public Task DeleteContactus(int id)
        {
         return _contactusRepository.DeleteContactus(id);
        }
    }
}
