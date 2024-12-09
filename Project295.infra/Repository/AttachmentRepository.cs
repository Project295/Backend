using Dapper;
using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class AttachmentRepository: IAttachmentRepository
    {
        private readonly IDbContext _dbContext;

        public AttachmentRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
