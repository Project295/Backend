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
    public class AttachmentTypeServices : IAttachmentTypeServices
    {
        private readonly IAttachmentTypeRepository _attachmentTypeRepository;
        public AttachmentTypeServices(IAttachmentTypeRepository attachmentTypeRepository)
        {
            _attachmentTypeRepository = attachmentTypeRepository;
        }
        public Task<List<AttachmentType>> GetAllAttachmentType()
        {
            return _attachmentTypeRepository.GetAllAttachmentType();
        }

        public Task<AttachmentType> GetAttachmentTypeById(int id)
        {
            return _attachmentTypeRepository.GetAttachmentTypeById(id);
        }

        public Task CreateAttachmentType(AttachmentType attachmentType)
        {
            return _attachmentTypeRepository.CreateAttachmentType(attachmentType);
        }

        public Task UpdateAttachmentType(AttachmentType attachmentType)
        {
            return _attachmentTypeRepository.UpdateAttachmentType(attachmentType);
        }

        public Task DeleteAttachmentType(int id)
        {
            return _attachmentTypeRepository.DeleteAttachmentType(id);
        }
    }
}
