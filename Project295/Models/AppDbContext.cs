using Microsoft.EntityFrameworkCore;
using Project295.API.Models;

namespace Project295.API.Common
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<AttachmentType> AttachmentTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Complain> Complains { get; set; }
        public DbSet<ContactU> ContactUs { get; set; }
        public DbSet<Follower> Followers { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PostStatus> PostStatus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillsCategory> SkillsCategories { get; set; }
        public DbSet<UserExperience> UserExperiences { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure primary key for ContactU
            modelBuilder.Entity<ContactU>()
                .HasKey(c => c.ContactUsId);  // Define ContactUsId as the primary key

            // Relationships and other configurations

            // Role - Login (One-to-Many)
            modelBuilder.Entity<Login>()
                .HasOne(l => l.Role)
                .WithMany(r => r.Logins)
                .HasForeignKey(l => l.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            // Login - User (One-to-One or Many-to-One)
            modelBuilder.Entity<Login>()
                .HasOne(l => l.User)
                .WithMany(u => u.Logins)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Follower - User (Many-to-Many relationship between Users)
            modelBuilder.Entity<Follower>()
                .HasOne(f => f.User)
                .WithMany(u => u.FollowerUsers)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Follower>()
                .HasOne(f => f.Followed)
                .WithMany(u => u.FollowerFolloweds)
                .HasForeignKey(f => f.FollowedId)
                .OnDelete(DeleteBehavior.Restrict);

            // Complain - User (Many Complains per User, One User per Complainant)
            modelBuilder.Entity<Complain>()
                .HasOne(c => c.Complainant)
                .WithMany(u => u.ComplainComplainants)
                .HasForeignKey(c => c.ComplainantId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Complain>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Complains)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Complain>()
                .HasOne(c => c.User)
                .WithMany(u => u.ComplainUsers)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Post - Category (Many-to-One)
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Post - PostStatus (Many-to-One)
            modelBuilder.Entity<Post>()
                .HasOne(p => p.PostStatus)
                .WithMany(ps => ps.Posts)
                .HasForeignKey(p => p.PostStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attachment - Post (Many-to-One)
            modelBuilder.Entity<Attachment>()
                .HasOne(a => a.Post)
                .WithMany(p => p.Attachments)
                .HasForeignKey(a => a.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attachment - User (Many-to-One)
            modelBuilder.Entity<Attachment>()
                .HasOne(a => a.User)
                .WithMany(u => u.Attachments)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attachment - AttachmentType (Many-to-One)
            modelBuilder.Entity<Attachment>()
                .HasOne(a => a.AttachmentType)
                .WithMany(at => at.Attachments)
                .HasForeignKey(a => a.AttachmentTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserSkill - Skill (Many-to-One)
            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.Skill)
                .WithMany(s => s.UserSkills)
                .HasForeignKey(us => us.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserSkill - User (Many-to-One)
            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.User)
                .WithMany(u => u.UserSkills)
                .HasForeignKey(us => us.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserSkill - SkillsCategory (Many-to-One)
            modelBuilder.Entity<UserSkill>()
                .HasOne(us => us.SkillCategory)
                .WithMany(sc => sc.UserSkills)
                .HasForeignKey(us => us.SkillCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserExperience - User (Many-to-One)
            modelBuilder.Entity<UserExperience>()
                .HasOne(ue => ue.User)
                .WithMany(u => u.UserExperiences)
                .HasForeignKey(ue => ue.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserProject - User (Many-to-One)
            modelBuilder.Entity<UserProject>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserProjects)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Category - Post (One-to-Many)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Posts)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // PostStatus - Post (One-to-Many)
            modelBuilder.Entity<PostStatus>()
                .HasMany(ps => ps.Posts)
                .WithOne(p => p.PostStatus)
                .HasForeignKey(p => p.PostStatusId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
