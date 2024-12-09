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
        public Task<List<AttachmentType>> GetAllAttachmentType()
        {
            return _attachmentTypeServices.GetAllAttachmentType();
        }
        [HttpGet]
        [Route("GetAttachmentTypeById")]
        public Task<AttachmentType> GetAttachmentTypeById(int id)
        {
            return _attachmentTypeServices.GetAttachmentTypeById(id);
        }
        [HttpPost]
        [Route("CreateAttachmentType")]
        public Task CreateAttachmentType(AttachmentType attachmentType)
        {
            return _attachmentTypeServices.CreateAttachmentType(attachmentType);
        }
        [HttpPut]
        [Route("UpdateAttachmentType")]
        public Task UpdateAttachmentType(AttachmentType attachmentType)
        {
            return _attachmentTypeServices.UpdateAttachmentType(attachmentType);
        }
        [HttpDelete]
        [Route("DeleteAttachmentType")]
        public Task DeleteAttachmentType(int id)
        {
            return _attachmentTypeServices.DeleteAttachmentType(id);
        }
    }
}
