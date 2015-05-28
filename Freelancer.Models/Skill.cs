using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelancer.Models
{
    public class Skill
    {
        private ICollection<Project> projects;
        private ICollection<User> users;

        public Skill()
        {
            this.projects = new HashSet<Project>();
            this.users = new HashSet<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual ICollection<Project> Projects
        {
            get
            {
                return this.projects;
            }
        }

        public virtual ICollection<User> Users
        {
            get
            {
                return this.users;
            }
        }
    }
}
