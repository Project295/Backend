using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IFollowerRepository
    {
         List<Follower> GetAllFollowers();
         Follower GetFollowerById(int id);
         void CreateFollower(Follower follower);
         void UpdateFollower(Follower follower);
         void DeleteFollower(int id);
    }
}
