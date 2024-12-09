using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class AttachmentTypeRepository : IAttachmentTypeRepository
    {
        private readonly IDbContext _dbContext;

        public AttachmentTypeRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
