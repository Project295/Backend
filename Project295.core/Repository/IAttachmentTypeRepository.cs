using Project295.API.Models;
using Project295.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Repository
{
    public interface IAttachmentTypeRepository
    {
         List<AttachmentType> GetAllAttachmentType();
         AttachmentType GetAttachmentTypeById(int id);
         void CreateAttachmentType(AttachmentType attachmentType);
         void UpdateAttachmentType(AttachmentType attachmentType);
         void DeleteAttachmentType(int id);
    }
}
