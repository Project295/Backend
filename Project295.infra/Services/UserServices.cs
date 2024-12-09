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
    public class UserServices: IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
