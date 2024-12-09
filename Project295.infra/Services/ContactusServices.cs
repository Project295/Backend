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
