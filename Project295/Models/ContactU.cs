using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class ContactU
    {
        public int ContactUsId { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public string? Name { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
