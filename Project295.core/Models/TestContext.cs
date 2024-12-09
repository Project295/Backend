using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project295.API.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attachment> Attachments { get; set; } = null!;
        public virtual DbSet<AttachmentType> AttachmentTypes { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Complain> Complains { get; set; } = null!;
        public virtual DbSet<ContactU> ContactUs { get; set; } = null!;
        public virtual DbSet<Follower> Followers { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PostStatus> PostStatuses { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<SkillsCategory> SkillsCategories { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserExperience> UserExperiences { get; set; } = null!;
        public virtual DbSet<UserProject> UserProjects { get; set; } = null!;
        public virtual DbSet<UserSkill> UserSkills { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ALAMANI;Database=Test;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachment");

                entity.Property(e => e.AttachmentId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .HasConstraintName("FK__Attachmen__Attac__4F7CD00D");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Attachmen__PostI__5165187F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Attachmen__UserI__5070F446");
            });

            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.ToTable("AttachmentType");

                entity.Property(e => e.AttachmentTypeId).ValueGeneratedNever();

                entity.Property(e => e.AttachmentTypeName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("attachmentTypeName");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Complain>(entity =>
            {
                entity.ToTable("Complain");

                entity.Property(e => e.ComplainId).ValueGeneratedNever();

                entity.Property(e => e.ComplainDiscription)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PostId).HasColumnName("postId");

                entity.HasOne(d => d.Complainant)
                    .WithMany(p => p.ComplainComplainants)
                    .HasForeignKey(d => d.ComplainantId)
                    .HasConstraintName("FK__Complain__Compla__6477ECF3");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Complains)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Complain__postId__656C112C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ComplainUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Complain__UserId__66603565");
            });

            modelBuilder.Entity<ContactU>(entity =>
            {
                entity.HasKey(e => e.ContactUsId)
                    .HasName("PK__ContactU__E10B7AC8A61C079B");

                entity.Property(e => e.ContactUsId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Follower>(entity =>
            {
                entity.Property(e => e.FollowerId).ValueGeneratedNever();

                entity.HasOne(d => d.Followed)
                    .WithMany(p => p.FollowerFolloweds)
                    .HasForeignKey(d => d.FollowedId)
                    .HasConstraintName("FK__Followers__Follo__4222D4EF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Followers__UserI__412EB0B6");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.HasIndex(e => e.Password, "UQ__Login__87909B158093D7CB")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UQ__Login__C9F284566AC75E6B")
                    .IsUnique();

                entity.Property(e => e.LoginId).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Login__RoleId__3D5E1FD2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Login__UserId__3E52440B");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.PostId).ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Contant)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Post__categoryId__48CFD27E");

                entity.HasOne(d => d.PostStatus)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostStatusId)
                    .HasConstraintName("FK__Post__PostStatus__49C3F6B7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Post__UserId__4AB81AF0");
            });

            modelBuilder.Entity<PostStatus>(entity =>
            {
                entity.ToTable("PostStatus");

                entity.Property(e => e.PostStatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).ValueGeneratedNever();

                entity.Property(e => e.SkillName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("skillName");
            });

            modelBuilder.Entity<SkillsCategory>(entity =>
            {
                entity.Property(e => e.SkillsCategoryId).ValueGeneratedNever();

                entity.Property(e => e.SkillsCategoryName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserExperience>(entity =>
            {
                entity.Property(e => e.UserExperienceId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserExperienceDateFrom).HasColumnType("datetime");

                entity.Property(e => e.UserExperienceDateTo).HasColumnType("datetime");

                entity.Property(e => e.UserExperienceDiscription)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserExperiences)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserExper__userI__5EBF139D");
            });

            modelBuilder.Entity<UserProject>(entity =>
            {
                entity.Property(e => e.UserProjectId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserProjectDiscription)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserProje__userI__619B8048");
            });

            modelBuilder.Entity<UserSkill>(entity =>
            {
                entity.ToTable("UserSkill");

                entity.Property(e => e.UserSkillId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.OtherSkill)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.SkillCategory)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.SkillCategoryId)
                    .HasConstraintName("FK__UserSkill__Skill__5BE2A6F2");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__UserSkill__Skill__59FA5E80");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserSkill__userI__5AEE82B9");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
