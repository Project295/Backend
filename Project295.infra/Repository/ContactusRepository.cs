using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class ContactusRepository : IContactusRepository
    {
        private readonly IDbContext _dbContext;

        public ContactusRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
