using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project295.API.Models;

namespace Project295.Core.Services
{
    public interface IAttachmentServices
    {
        Task<List<Attachment>> GetAllAttachment();
        Task<Attachment> GetAttachmentById(int id);
        Task CreateAttachment(Attachment attachment);
        Task UpdateAttachment(Attachment attachment);
        Task DeleteAttachment(int id);
    }
}
