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
    public class ComplainServices : IComplainServices
    {
        private readonly IComplainRepository _complainRepository;
        public ComplainServices(IComplainRepository complainRepository)
        {
            _complainRepository = complainRepository;
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
