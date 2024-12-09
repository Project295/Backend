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
    public class UserRepository: IUserRepository
    {
        private readonly IDbContext _dbContext;

        public UserRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<User> GetAllUsers()
        {
            return null;

        }

        public User GetUserById(int id)
        {
            return null;

        }

        public void CreateUser(User user)
        {

        }

        public void UpdateUser(User user)
        {

        }

        public void DeleteUser(int id)
        {

        }
    }
}
