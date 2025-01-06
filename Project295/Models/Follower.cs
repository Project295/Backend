using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class Follower
    {
        public int FollowerId { get; set; }
        public int? UserId { get; set; }
        public int? FollowedId { get; set; }

        public virtual User? Followed { get; set; }
        public virtual User? User { get; set; }
    }
}
