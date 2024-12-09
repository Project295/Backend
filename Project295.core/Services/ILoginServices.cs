using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface ILoginServices
    {
        Task<List<Login>> GetAllLogins();
        Task<Login> GetLoginById(int id);
        Task CreateLogin(Login login);
        Task UpdateLogin(Login login);
        Task DeleteLogin(int id);
    }
}
