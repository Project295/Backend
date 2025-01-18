using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class Attachment
    {
        public int AttachmentId { get; set; }
        public int? AttachmentTypeId { get; set; }
        public string? AttachmentPath { get; set; }

        public int? UserId { get; set; }
        public int? PostId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual AttachmentType? AttachmentType { get; set; }
        public virtual Post? Post { get; set; }
        public virtual User? User { get; set; }
    }
}
