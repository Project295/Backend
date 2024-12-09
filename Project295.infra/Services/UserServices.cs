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
        public Task<List<User>> GetAllUsers()
        {
            return _userRepository.GetAllUsers();

        }

        public Task<User> GetUserById(int id)
        {
            return _userRepository.GetUserById(id);

        }

        public Task CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public Task UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }

        public Task DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);

        }
    }
}
