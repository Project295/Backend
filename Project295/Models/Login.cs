using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual User? User { get; set; }
    }
}
