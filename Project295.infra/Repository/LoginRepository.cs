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
    public class LoginRepository: ILoginRepository
    {
        private readonly IDbContext _dbContext;

        public LoginRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
