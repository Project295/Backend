using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class SkillsCategory
    {
        public SkillsCategory()
        {
            UserSkills = new HashSet<UserSkill>();
        }

        public int SkillsCategoryId { get; set; }
        public string? SkillsCategoryName { get; set; }

        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
