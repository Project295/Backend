using Microsoft.EntityFrameworkCore;
using Project295.API.Models;

namespace Project295.API.Common
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<AttachmentType> AttachmentTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Complain> Complains { get; set; }
        public DbSet<ContactU> ContactUs { get; set; }
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
            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachment");

                entity.Property(e => e.AttachmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");
                entity.Property(e => e.AttachmentPath)
                      .HasMaxLength(1)
                      .IsUnicode(false);

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .HasConstraintName("FK__Attachmen__Attac__4F7CD00D");

                entity.HasOne(d => d.Post)
                    .WithOne(p => p.Attachments)
                    .HasForeignKey<Attachment>(d => d.PostId)
                    .HasConstraintName("FK__Attachmen__PostI__5165187F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Attachmen__UserI__5070F446");
            });

            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.ToTable("AttachmentType");

                entity.Property(e => e.AttachmentTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.AttachmentTypeName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("attachmentTypeName");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Complain>(entity =>
            {
                entity.ToTable("Complain");

                entity.Property(e => e.ComplainId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.ContactUsId).ValueGeneratedOnAdd();

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

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.HasIndex(e => e.Password, "UQ__Login__87909B158093D7CB")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UQ__Login__C9F284566AC75E6B")
                    .IsUnique();

                entity.Property(e => e.LoginId).ValueGeneratedOnAdd();

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
                    .WithOne(p => p.Logins)
                    .HasForeignKey<Login>(d => d.UserId)
                    .HasConstraintName("FK__Login__UserId__3E52440B");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.PostId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.PostStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).ValueGeneratedOnAdd();

                entity.Property(e => e.RoleName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).ValueGeneratedOnAdd();

                entity.Property(e => e.SkillName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("skillName");

                entity.Property(e => e.SkillCategoryId).HasColumnName("SkillCategoryId");
                entity.HasOne(d => d.SkillsCategory)
                  .WithMany(p => p.Skills)
                  .HasForeignKey(d => d.SkillCategoryId)
                  .HasConstraintName("FK__Skills__SkillCat__619B8048");
            });

            modelBuilder.Entity<SkillsCategory>(entity =>
            {
                entity.Property(e => e.SkillsCategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.SkillsCategoryName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Brif)
              .HasMaxLength(1000)
              .IsUnicode(false);
                entity.Property(e => e.Address)
              .HasMaxLength(1000)
              .IsUnicode(false);
                entity.Property(e => e.JobTitle)
              .HasMaxLength(1000)
              .IsUnicode(false);
                entity.Property(e => e.Univarsity)
              .HasMaxLength(1000)
              .IsUnicode(false);
                entity.Property(e => e.Company)
          .HasMaxLength(1000)
          .IsUnicode(false);
            });

            modelBuilder.Entity<UserExperience>(entity =>
            {
                entity.Property(e => e.UserExperienceId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserExperienceDateFrom).HasColumnType("datetime");

                entity.Property(e => e.UserExperienceDateTo).HasColumnType("datetime");

                entity.Property(e => e.UserExperienceTitle)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                 entity.Property(e => e.UserExperienceTitle)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                 entity.Property(e => e.UniversityName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
                
                entity.Property(e => e.CertificationName)
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
                entity.Property(e => e.UserProjectId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserProjectsTitle)
                    .HasMaxLength(1)
                    .IsUnicode(false);    
                
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

                entity.Property(e => e.UserSkillId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");


                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__UserSkill__Skill__59FA5E80");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserSkill__userI__5AEE82B9");
            });

        }
    }
}
