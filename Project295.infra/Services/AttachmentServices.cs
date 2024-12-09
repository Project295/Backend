using Project295.Core.Repository;
using Project295.Core.Services;
using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Services
{
    public class AttachmentServices: IAttachmentServices
    {
        private readonly IAttachmentRepository _attachmentRepository;
        public AttachmentServices(IAttachmentRepository attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
        }
        public Task<List<Attachment>> GetAllAttachment()
        {
            return _attachmentRepository.GetAllAttachment();
        }

        public Task<Attachment> GetAttachmentById(int id)
        {
            return _attachmentRepository.GetAttachmentById(id);
        }

        public Task CreateAttachment(Attachment attachment)
        {
            return _attachmentRepository.CreateAttachment(attachment);
        }

        public Task UpdateAttachment(Attachment attachment)
        {
            return _attachmentRepository.UpdateAttachment(attachment);
        }

        public Task DeleteAttachment(int id)
        {
            return _attachmentRepository.DeleteAttachment(id);
        }
    }
}
