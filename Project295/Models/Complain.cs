using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class Complain
    {
        public int ComplainId { get; set; }
        public string? ComplainDiscription { get; set; }
        public int? ComplainantId { get; set; }
        public int? PostId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? IsActive { get; set; }

        public virtual User? Complainant { get; set; }
        public virtual Post? Post { get; set; }
        public virtual User? User { get; set; }
    }
}
