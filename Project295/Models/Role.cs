﻿using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class Role
    {
        public Role()
        {
            Logins = new HashSet<Login>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
    }
}
