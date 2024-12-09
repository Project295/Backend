using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Services
{
    public class FollowerServices: IFollowerServices
    {
        private readonly IFollowerRepository _followerRepository;
        public FollowerServices(IFollowerRepository followerRepository)
        {
            _followerRepository = followerRepository;
        }
        public List<Follower> GetAllFollowers()
        {
            return null;
        }
        public Follower GetFollowerById(int id)
        {
            return null;

        }
        public void CreateFollower(Follower follower)
        {

        }
        public void UpdateFollower(Follower follower)
        {

        }
        public void DeleteFollower(int id)
        {

        }
    }
}
