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
        public List<AttachmentType> GetAllAttachmentType()
        {
            return null;
        }

        public AttachmentType GetAttachmentTypeById(int id)
        {
            return null;
        }

        public void CreateAttachmentType(AttachmentType attachmentType)
        {

        }

        public void UpdateAttachmentType(AttachmentType attachmentType)
        {

        }

        public void DeleteAttachmentType(int id)
        {

        }
    }
}
