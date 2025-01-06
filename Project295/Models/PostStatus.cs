using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class PostStatus
    {
        public PostStatus()
        {
            Posts = new HashSet<Post>();
        }

        public int PostStatusId { get; set; }
        public string? StatusName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
