using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class Post
    {
        public Post()
        {
            Attachments = new HashSet<Attachment>();
            Complains = new HashSet<Complain>();
        }

        public int PostId { get; set; }
        public string? Contant { get; set; }
        public int? CategoryId { get; set; }
        public int? PostStatusId { get; set; }
        public int? UserId { get; set; }
        public bool? IsBlocked { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Category? Category { get; set; }
        public virtual PostStatus? PostStatus { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<Complain> Complains { get; set; }
    }
}
