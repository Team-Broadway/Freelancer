using Freelancer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data
{
    public interface IApplicationDbContext
    {

        IDbSet<Exam> Exams { get; set; }

        IDbSet<Project> Projects { get; set; }

        IDbSet<ProjectEmployee> ProjectEmployees { get; set; }

        IDbSet<Message> Messages { get; set; }

        IDbSet<Question> Questions { get; set; }

        IDbSet<Review> Reviews { get; set; }

        IDbSet<Skill> Skills { get; set; }

        IDbSet<Notification> Notifications { get; set; }
    }
}
