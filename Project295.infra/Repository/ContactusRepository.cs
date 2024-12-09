using Microsoft.EntityFrameworkCore;
using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using Project295.Infra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class ContactusRepository : IContactusRepository
    {
        private readonly AppDbContext _dbContext;

        public ContactusRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ContactU>> GetAllContactus()
        {
            return await _dbContext.ContactUs.ToListAsync();

        }

        public async Task<ContactU> GetContactusById(int id)
        {
            return await _dbContext.ContactUs.FirstOrDefaultAsync(x => x.ContactUsId == id);

        }

        public async Task CreateContactus(ContactU contactU)
        {
            _dbContext.ContactUs.Add(contactU);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateContactus(ContactU contactU)
        {
            _dbContext.ContactUs.Update(contactU);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteContactus(int id)
        {
            var contactUs = await _dbContext.ContactUs.FirstOrDefaultAsync(x => x.ContactUsId == id);
            if (contactUs != null)
            {
                _dbContext.Remove(contactUs);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
