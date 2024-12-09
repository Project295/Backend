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
        public Task<List<Login>> GetAllLogins()
        {
            return _loginRepository.GetAllLogins();

        }

        public Task<Login> GetLoginById(int id)
        {
            return _loginRepository.GetLoginById(id);

        }

        public Task CreateLogin(Login login)
        {
            return _loginRepository.CreateLogin(login);
        }

        public Task UpdateLogin(Login login)
        {
            return _loginRepository.UpdateLogin(login);
        }

        public Task DeleteLogin(int id)
        {
            return _loginRepository.DeleteLogin(id);
        }
    }
}
