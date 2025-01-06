using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class AttachmentType
    {
        public AttachmentType()
        {
            Attachments = new HashSet<Attachment>();
        }

        public int AttachmentTypeId { get; set; }
        public string? AttachmentTypeName { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
