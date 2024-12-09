using Microsoft.EntityFrameworkCore;
using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using Project295.Infra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class AttachmentTypeRepository : IAttachmentTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public AttachmentTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<AttachmentType>> GetAllAttachmentType()
        {
            return await _dbContext.AttachmentTypes.ToListAsync();
        }

        public async Task<AttachmentType> GetAttachmentTypeById(int id)
        {
            return await _dbContext.AttachmentTypes.FirstOrDefaultAsync(x => x.AttachmentTypeId == id);
        }

        public async Task CreateAttachmentType(AttachmentType attachmentType)
        {
            _dbContext.AttachmentTypes.Add(attachmentType);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAttachmentType(AttachmentType attachmentType)
        {
            _dbContext.AttachmentTypes.Update(attachmentType);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAttachmentType(int id)
        {
            var attachmentType = await _dbContext.AttachmentTypes.FirstOrDefaultAsync(x => x.AttachmentTypeId == id);
            if (attachmentType != null)
            {
                _dbContext.Remove(attachmentType);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
