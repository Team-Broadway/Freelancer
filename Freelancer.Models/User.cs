using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class User : IdentityUser
    {
        private ICollection<ProjectEmployee> projectEmployee;
        private ICollection<BiddingProjectEmployee> biddingProjectEmployee;
        private ICollection<Project> bookmarkedProjects;

        private ICollection<Skill> skills;
        private ICollection<Exam> exams;
        private ICollection<Notification> notifications;
        private ICollection<Review> reviews;

 
        public User()
        {
            this.projectEmployee = new HashSet<ProjectEmployee>();
            this.biddingProjectEmployee = new HashSet<BiddingProjectEmployee>();
            this.bookmarkedProjects = new HashSet<Project>();
            this.reviews = new HashSet<Review>();
            this.skills = new HashSet<Skill>();
            this.exams = new HashSet<Exam>();
            this.notifications = new HashSet<Notification>();
        }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Info { get; set; }

        [DefaultValue(0)]
        [Range(0, 10000)]
        public int? Experience { get; set; }

        [DefaultValue(1)]
        [Range(1, 100)]
        public int? Level { get; set; }

        public virtual ICollection<ProjectEmployee> ProjectEmployee
        {
            get { return this.projectEmployee; }
        }

        public virtual ICollection<BiddingProjectEmployee> BiddingProjectEmployee
        {
            get { return this.biddingProjectEmployee; }
        }

        public virtual ICollection<Project> BookmarkedProjects
        {
            get { return this.bookmarkedProjects; }
        }

        public virtual ICollection<Skill> Skills
        {
            get { return this.skills; }
        }

        public virtual ICollection<Exam> Exams
        {
            get { return this.exams; }
        }

        public virtual ICollection<Notification> Notifications
        {
            get { return this.notifications; }
        }

        public virtual ICollection<Review> Reviews
        {
            get { return this.reviews; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }



    }
}
