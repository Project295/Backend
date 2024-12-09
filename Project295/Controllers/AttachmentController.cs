using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.Core.Services;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly IAttachmentServices _attachmentServices;
        public AttachmentController(IAttachmentServices attachmentServices)
        {
            _attachmentServices = attachmentServices;
        }

        [HttpGet]
        public Task<List<Attachment>> GetAllAttachment()
        {
            return _attachmentServices.GetAllAttachment();
        }

        [HttpGet]
        [Route("GetAttachmentById")]
        public Task<Attachment> GetAttachmentById(int id)
        {
            return _attachmentServices.GetAttachmentById(id);
        }

        [HttpPost]
        [Route("CreateAttachment")]
        public Task CreateAttachment(Attachment attachment)
        {
            return _attachmentServices.CreateAttachment(attachment);
        }

        [HttpPut]
        [Route("UpdateAttachment")]
        public Task UpdateAttachment(Attachment attachment)
        {
            return _attachmentServices.UpdateAttachment(attachment);
        }

        [HttpDelete]
        [Route("DeleteAttachment")]
        public Task DeleteAttachment(int id)
        {
            return _attachmentServices.DeleteAttachment(id);
        }
    }
}
