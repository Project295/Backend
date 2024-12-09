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
        Task<List<AttachmentType>> GetAllAttachmentType();
        Task<AttachmentType> GetAttachmentTypeById(int id);
        Task CreateAttachmentType(AttachmentType attachmentType);
        Task UpdateAttachmentType(AttachmentType attachmentType);
        Task DeleteAttachmentType(int id);
    }
}
