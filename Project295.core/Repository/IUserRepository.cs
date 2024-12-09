using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IUserRepository
    {
         Task<List<User>> GetAllUsers();
         Task<User> GetUserById(int id);
         Task CreateUser(User user);
         Task UpdateUser(User user);
         Task DeleteUser(int id);
    }
}
