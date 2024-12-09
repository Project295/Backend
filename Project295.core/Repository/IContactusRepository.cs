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
         List<ContactU> GetAllContactus();
         ContactU GetContactusById(int id);
         void CreateContactus(ContactU contactU);
         void UpdateContactus(ContactU contactU);
         void DeleteContactus(int id);
    }
}
