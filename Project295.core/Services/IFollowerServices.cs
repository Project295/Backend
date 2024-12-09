using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface IFollowerServices
    {
        Task<List<Follower>> GetAllFollowers();
        Task<Follower> GetFollowerById(int id);
        Task CreateFollower(Follower follower);
        Task UpdateFollower(Follower follower);
        Task DeleteFollower(int id);
    }
}
