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
         List<User> GetAllUsers();
         User GetUserById(int id);
         void CreateUser(User user);
         void UpdateUser(User user);
         void DeleteUser(int id);
    }
}
