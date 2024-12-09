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
        public Task<List<Complain>> GetAllComplain()
        {
            return _complainRepository.GetAllComplain();

        }

        public Task<Complain> GetComplainById(int id)
        {
            return _complainRepository.GetComplainById(id);

        }

        public Task CreateComplain(Complain complain)
        {
            return _complainRepository.UpdateComplain(complain);
        }

        public Task UpdateComplain(Complain complain)
        {
            return _complainRepository.UpdateComplain(complain);
        }

        public Task DeleteComplain(int id)
        {
            return _complainRepository.DeleteComplain(id);
        }
    }
}
