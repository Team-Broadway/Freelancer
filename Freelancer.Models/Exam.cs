using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelancer.Models
{
    public class Exam
    {
        private ICollection<User> employees;
        private ICollection<Question> questions;

        public Exam()
        {
            this.employees = new HashSet<User>();
            this.questions = new HashSet<Question>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Employees { get { return employees; } }

        public virtual ICollection<Question> Questions { get { return questions; } }
    }
}
