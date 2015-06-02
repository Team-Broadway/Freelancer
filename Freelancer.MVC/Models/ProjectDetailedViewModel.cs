using Freelancer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Freelancer.MVC.Models
{
    public class ProjectDetailedViewModel : ProjectViewModel
    {
        public ICollection<BiddingProjectEmployee> BiddingProjectEmployee { get; set; }

        public ICollection<ProjectEmployee> ProjectEmployee { get; set; }

        public bool IsOpen { get; set; }

        public bool BidMenuOpen { get; set; }

        [DisplayName("Due Date")]
        public string DueDate { get; set; }
    }
}