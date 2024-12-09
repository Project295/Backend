using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface IAttachmentTypeServices
    {
         List<AttachmentType> GetAllAttachmentType();
         AttachmentType GetAttachmentTypeById(int id);
         void CreateAttachmentType(AttachmentType attachmentType);
         void UpdateAttachmentType(AttachmentType attachmentType);
         void DeleteAttachmentType(int id);
    }
}
