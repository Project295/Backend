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
    public class FollowerRepository: IFollowerRepository
    {
        private readonly IDbContext _dbContext;

        public FollowerRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
