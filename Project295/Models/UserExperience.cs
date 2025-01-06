using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class UserExperience
    {
        public int UserExperienceId { get; set; }
        public string? UserExperienceDiscription { get; set; }
        public DateTime? UserExperienceDateFrom { get; set; }
        public DateTime? UserExperienceDateTo { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User? User { get; set; }
    }
}
