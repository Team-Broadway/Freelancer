using Freelancer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Freelancer.MVC.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

        [DisplayName("Project Name")]
        public string Title { get; set; }

        public int Bids { get; set; }

        public IEnumerable<string> Skills { get; set; }

        [DisplayName("Started")]
        public string StartDate { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }

        public ICollection<User> BookmarkedUsers { get; set; }

        public User Employer { get; set; }
    }
}