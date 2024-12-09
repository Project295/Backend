using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IContactusRepository
    {
        Task<List<ContactU>> GetAllContactus();
        Task<ContactU> GetContactusById(int id);
        Task CreateContactus(ContactU contactU);
        Task UpdateContactus(ContactU contactU);
        Task DeleteContactus(int id);
    }
}
