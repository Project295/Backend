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
        public Task<List<Follower>> GetAllFollowers()
        {
            return _followerRepository.GetAllFollowers();   
        }
        public Task<Follower> GetFollowerById(int id)
        {
            return _followerRepository.GetFollowerById(id);

        }
        public Task CreateFollower(Follower follower)
        {
            return _followerRepository.CreateFollower(follower);    
        }
        public Task UpdateFollower(Follower follower)
        {
            return _followerRepository.UpdateFollower(follower);
        }
        public Task DeleteFollower(int id)
        {
            return _followerRepository.DeleteFollower(id);
        }
    }
}
