using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class UserProject
    {
        public int UserProjectId { get; set; }
        public string? UserProjectDiscription { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User? User { get; set; }
    }
}
