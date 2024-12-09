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
         List<Attachment> GetAllAttachment();
         Attachment GetAttachmentById(int id);
         void CreateAttachment(Attachment attachment);
         void UpdateAttachment(Attachment attachment);
         void DeleteAttachment(int id);
    }
}
