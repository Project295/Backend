using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project295.API.Common;
using Project295.API.Models;


namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public AttachmentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Attachment> GetAllAttachment()
        {
            return _dbContext.Attachments.ToList();
             
        }

        [HttpGet]
        [Route("GetAttachmentById")]
        public Attachment GetAttachmentById(int id)
        {
            return  _dbContext.Attachments.FirstOrDefault(x => x.PostId == id);
        }

        [HttpPost]
        [Route("CreateAttachment")]
        public void CreateAttachment(Attachment attachment)
        {
             _dbContext.Attachments.Add(attachment);
        }

        [HttpPut]
        [Route("UpdateAttachment")]
        public void UpdateAttachment(Attachment attachment)
        {
            _dbContext.Attachments.Update(attachment);
        }

        [HttpDelete]
        [Route("DeleteAttachment")]
        public void DeleteAttachment(int id)
        {
            var attachment = _dbContext.Attachments.FirstOrDefault(x => x.PostId == id);
            _dbContext.Attachments.Remove(attachment);
        }
    }
}
