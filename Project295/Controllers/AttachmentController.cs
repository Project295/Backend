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
        public List<Attachment> GetAllAttachment()
        {
            return null;
        }

        [HttpGet]
        [Route("GetAttachmentById")]
        public Attachment GetAttachmentById(int id)
        {
            return null;

        }

        [HttpPost]
        [Route("CreateAttachment")]
        public void CreateAttachment(Attachment attachment)
        {

        }

        [HttpPut]
        [Route("UpdateAttachment")]
        public void UpdateAttachment(Attachment attachment)
        {

        }

        [HttpDelete]
        [Route("DeleteAttachment")]
        public void DeleteAttachment(int id)
        {

        }
    }
}
