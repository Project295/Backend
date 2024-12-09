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
        public List<Attachment> GetAllAttachment()
        {
            return null;
        }

        public Attachment GetAttachmentById(int id)
        {
            return null;
        }

        public void CreateAttachment(Attachment attachment)
        {

        }

        public void UpdateAttachment(Attachment attachment)
        {

        }

        public void DeleteAttachment(int id)
        {

        }
    }
}
