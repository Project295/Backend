using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class SkillsCategory
    {
        public SkillsCategory()
        {
            Skills = new HashSet<Skill>();
        }

        public int SkillsCategoryId { get; set; }
        public string? SkillsCategoryName { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

    }
}
