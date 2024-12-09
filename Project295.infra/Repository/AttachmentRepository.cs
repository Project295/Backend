using Dapper;
using Microsoft.EntityFrameworkCore;
using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using Project295.Infra.Common;
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
        private readonly AppDbContext _dbContext;

        public AttachmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Attachment>> GetAllAttachment()
        {
            return await _dbContext.Attachments.ToListAsync();
        }

        public async Task<Attachment> GetAttachmentById(int id)
        {
            return await _dbContext.Attachments.FirstOrDefaultAsync(x => x.AttachmentId == id);
        }

        public async Task CreateAttachment(Attachment attachment)
        {
            _dbContext.Attachments.Add(attachment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAttachment(Attachment attachment)
        {
            _dbContext.Attachments.Update(attachment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAttachment(int id)
        {
            var attachment = await _dbContext.Attachments.FirstOrDefaultAsync(x => x.AttachmentId == id);
            if (attachment != null)
            {
                _dbContext.Remove(attachment);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
