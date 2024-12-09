using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IComplainRepository
    {
        Task<List<Complain>> GetAllComplain();
        Task<Complain> GetComplainById(int id);
        Task CreateComplain(Complain complain);
        Task UpdateComplain(Complain complain);
        Task DeleteComplain(int id);
    }
}
