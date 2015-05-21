using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelancer.Models
{
    public class Project
    {

        private ICollection<Skill> skills;

        private ICollection<User> biddingEmployees;

        private ICollection<User> bookmarkedUsers;

        private ICollection<ProjectEmployee> projectEmployee;

        public Project()
        {
            this.skills = new HashSet<Skill>();
            this.biddingEmployees = new HashSet<User>();
            this.bookmarkedUsers = new HashSet<User>();
            this.projectEmployee = new HashSet<ProjectEmployee>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal StartPrice { get; set; }

        public decimal EndPrice { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsOpen { get; set; }

        public int MaxExperience { get; set; }

        public virtual User Employer { get; set; }

        public virtual ICollection<Skill> Skills { get { return this.skills; } }

        public virtual ICollection<User> BiddingEmployees { get { return this.biddingEmployees; } }

        public virtual ICollection<User> BookmarkedUsers { get { return this.bookmarkedUsers; } }

        public virtual ICollection<ProjectEmployee> ProjectEmployee { get { return this.projectEmployee; } }
    }
}
