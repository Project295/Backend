using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;


namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentTypeController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public AttachmentTypeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<AttachmentType> GetAllAttachmentType()
        {
            return _dbContext.AttachmentTypes.ToList();
        }
        [HttpGet]
        [Route("GetAttachmentTypeById")]
        public AttachmentType GetAttachmentTypeById(int id)
        {
            return _dbContext.AttachmentTypes.FirstOrDefault(x=>x.AttachmentTypeId == id);
        }
        [HttpPost]
        [Route("CreateAttachmentType")]
        public void CreateAttachmentType(AttachmentType attachmentType)
        {
             _dbContext.AttachmentTypes.Add(attachmentType);
        }
        [HttpPut]
        [Route("UpdateAttachmentType")]
        public void UpdateAttachmentType(AttachmentType attachmentType)
        {
            _dbContext.AttachmentTypes.Update(attachmentType);
        }
        [HttpDelete]
        [Route("DeleteAttachmentType")]
        public void DeleteAttachmentType(int id)
        {
           var attachmentType = _dbContext.AttachmentTypes.FirstOrDefault(x => x.AttachmentTypeId == id);
            _dbContext.AttachmentTypes.Remove(attachmentType);
        }
    }
}
