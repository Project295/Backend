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
    public class LoginRepository: ILoginRepository
    {
        private readonly AppDbContext _dbContext;

        public LoginRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Login>> GetAllLogins()
        {
            return await _dbContext.Logins.ToListAsync();
        }

        public async Task<Login> GetLoginById(int id)
        {
            return await _dbContext.Logins.FirstOrDefaultAsync(x => x.LoginId == id);
        }

        public async Task CreateLogin(Login login)
        {
            _dbContext.Logins.Add(login);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateLogin(Login login)
        {
            _dbContext.Logins.Update(login);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteLogin(int id)
        {
            var login = await _dbContext.Logins.FirstOrDefaultAsync(x => x.UserId == id);
            if (login != null)
            {
                _dbContext.Remove(login);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
