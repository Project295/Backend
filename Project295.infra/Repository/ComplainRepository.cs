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
    public class ComplainRepository : IComplainRepository
    {
        private readonly IDbContext _dbContext;

        public ComplainRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Complain> GetAllComplain()
        {
            return null;

        }

        public Complain GetComplainById(int id)
        {
            return null;

        }

        public void CreateComplain(Complain complain)
        {

        }

        public void UpdateComplain(Complain complain)
        {

        }

        public void DeleteComplain(int id)
        {

        }
    }
}
