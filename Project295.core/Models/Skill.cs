using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class Skill
    {
        public Skill()
        {
            UserSkills = new HashSet<UserSkill>();
        }

        public int SkillId { get; set; }
        public int? SkillCategoryId { get; set; }
        public string? SkillName { get; set; }

        public virtual SkillsCategory? SkillCategory { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
