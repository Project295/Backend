using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface IComplainServices
    {
         List<Complain> GetAllComplain();
         Complain GetComplainById(int id);
         void CreateComplain(Complain complain);
         void UpdateComplain(Complain complain);
         void DeleteComplain(int id);
    }
}
