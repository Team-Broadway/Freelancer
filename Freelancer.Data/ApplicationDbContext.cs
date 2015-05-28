namespace Freelancer.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Freelancer.Models;
    using Freelancer.Data.Migrations;

    public class ApplicationDbContext : IdentityDbContext<User>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>()
           .HasMany(x => x.Skills)
           .WithMany(x => x.Projects)
            .Map(map =>
            {
                map.ToTable("ProjectSkill");
                map.MapLeftKey("ProjectId");
                map.MapRightKey("SkillId");
            });

            modelBuilder.Entity<User>()
          .HasMany(x => x.BiddingProjects)
          .WithMany(x => x.BiddingEmployees)
           .Map(map =>
           {
               map.ToTable("BiddingProjectEmployee");
               map.MapLeftKey("ProjectId");
               map.MapRightKey("EmployeeId");
           });

         //   modelBuilder.Entity<User>()
         //.HasMany(x => x.StartedProjects)
         //.WithMany(x => x.Employees)
         // .Map(map =>
         // {
         //     map.ToTable("StartedProjectEmployee");
         //     map.MapLeftKey("ProjectId");
         //     map.MapRightKey("EmployeeId");
         // });

            modelBuilder.Entity<User>()
         .HasMany(x => x.BookmarkedProjects)
         .WithMany(x => x.BookmarkedUsers)
          .Map(map =>
          {
              map.ToTable("BookmarkedProjectUser");
              map.MapLeftKey("ProjectId");
              map.MapRightKey("UserId");
          });

        }

        public IDbSet<Exam> Exams { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<ProjectEmployee> ProjectEmployees { get; set; }

        public IDbSet<Message> Messages { get; set; }

        public IDbSet<Question> Questions { get; set; }

        public IDbSet<Review> Reviews { get; set; }

        public IDbSet<Skill> Skills { get; set; }

        public IDbSet<Notification> Notifications { get; set; }
    }
}
