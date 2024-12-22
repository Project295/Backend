using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class UserSkill
    {
        public int UserSkillId { get; set; }
        public int? SkillId { get; set; }
        public string? OtherSkill { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Skill? Skill { get; set; }
        public virtual User? User { get; set; }
    }
}
