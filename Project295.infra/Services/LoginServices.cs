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
    public class LoginServices: ILoginServices
    {
        private readonly ILoginRepository _loginRepository;
        public LoginServices(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public List<Login> GetAllLogins()
        {
            return null;

        }

        public Login GetLoginById(int id)
        {
            return null;

        }

        public void CreateLogin(Login login)
        {

        }

        public void UpdateLogin(Login login)
        {

        }

        public void DeleteLogin(int id)
        {

        }
    }
}
