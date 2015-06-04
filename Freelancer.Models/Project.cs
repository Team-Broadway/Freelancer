using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Freelancer.Models
{
    public class Project
    {

        private ICollection<Skill> skills;

        private ICollection<User> bookmarkedUsers;

        private ICollection<ProjectEmployee> projectEmployee;

        private ICollection<BiddingProjectEmployee> biddingProjectEmployee;
        public Project()
        {
            this.skills = new HashSet<Skill>();
            this.bookmarkedUsers = new HashSet<User>();
            this.projectEmployee = new HashSet<ProjectEmployee>();
            this.biddingProjectEmployee = new HashSet<BiddingProjectEmployee>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int StartPrice { get; set; }
       
        public int EndPrice { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        [DefaultValue(true)]
        public bool IsOpen { get; set; }

        public int MaxExperience { get; set; }

        public virtual User Employer { get; set; }

        public virtual ICollection<Skill> Skills { get { return this.skills; } }

        public virtual ICollection<User> BookmarkedUsers { get { return this.bookmarkedUsers; } }

        public virtual ICollection<ProjectEmployee> ProjectEmployee { get { return this.projectEmployee; } }

        public virtual ICollection<BiddingProjectEmployee> BiddingProjectEmployee { get { return this.biddingProjectEmployee; } }
    }
}
