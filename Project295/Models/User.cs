﻿using System;
using System.Collections.Generic;

namespace Project295.API.Models
{
    public partial class User
    {
        public User()
        {
            Attachments = new HashSet<Attachment>();
            ComplainComplainants = new HashSet<Complain>();
            ComplainUsers = new HashSet<Complain>();
            Posts = new HashSet<Post>();
            UserExperiences = new HashSet<UserExperience>();
            UserProjects = new HashSet<UserProject>();
            UserSkills = new HashSet<UserSkill>();
        }

        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? IsBlocked { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Brif { get; set; }
        public string? Univarsity { get; set; }
        public string? Address { get; set; }
        public string? JobTitle { get; set; }
        public string? Company { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<Complain> ComplainComplainants { get; set; }
        public virtual ICollection<Complain> ComplainUsers { get; set; }
        public virtual Login? Logins { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<UserExperience> UserExperiences { get; set; }
        public virtual ICollection<UserProject> UserProjects { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
