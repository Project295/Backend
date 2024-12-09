using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentTypeController : ControllerBase
    {
        private readonly IAttachmentTypeServices _attachmentTypeServices;
        public AttachmentTypeController(IAttachmentTypeServices attachmentTypeServices)
        {
            _attachmentTypeServices = attachmentTypeServices;
        }
        [HttpGet]
        public List<AttachmentType> GetAllAttachmentType()
        {
            return null;
        }
        [HttpGet]
        [Route("GetAttachmentTypeById")]
        public AttachmentType GetAttachmentTypeById(int id)
        {
            return null;
        }
        [HttpPost]
        [Route("CreateAttachmentType")]
        public void CreateAttachmentType(AttachmentType attachmentType)
        {

        }
        [HttpPut]
        [Route("UpdateAttachmentType")]
        public void UpdateAttachmentType(AttachmentType attachmentType)
        {

        }
        [HttpDelete]
        [Route("DeleteAttachmentType")]
        public void DeleteAttachmentType(int id)
        {

        }
    }
}
