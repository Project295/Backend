using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public ComplainController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Complain> GetAllComplain()
        {
            return _dbContext.Complains.ToList();

        }
        [HttpGet]
        [Route("GetComplainById")]
        public Complain GetComplainById(int id)
        {
            return _dbContext.Complains.FirstOrDefault(x=>x.ComplainId == id);
        }
        [HttpPost]
        [Route("CreateComplain")]
        public void CreateComplain(Complain complain)
        {
            _dbContext.Complains.Add(complain);
        }
        [HttpPut]
        [Route("UpdateComplain")]
        public void UpdateComplain(Complain complain)
        {
            _dbContext.Complains.Update(complain);
        }
        [HttpDelete]
        [Route("DeleteComplain")]
        public void DeleteComplain(int id)
        {
            var complain = _dbContext.Complains.FirstOrDefault(x => x.ComplainId == id);
            _dbContext.Complains.Remove(complain);
        }
    }
}
