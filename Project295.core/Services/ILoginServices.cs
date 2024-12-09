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
        List<Login> GetAllLogins();
        Login GetLoginById(int id);
        void CreateLogin(Login login);
        void UpdateLogin(Login login);
        void DeleteLogin(int id);
    }
}
