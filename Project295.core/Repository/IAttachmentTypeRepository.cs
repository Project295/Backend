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
        Task<List<AttachmentType>> GetAllAttachmentType();
        Task<AttachmentType> GetAttachmentTypeById(int id);
        Task CreateAttachmentType(AttachmentType attachmentType);
        Task UpdateAttachmentType(AttachmentType attachmentType);
        Task DeleteAttachmentType(int id);
    }
}
