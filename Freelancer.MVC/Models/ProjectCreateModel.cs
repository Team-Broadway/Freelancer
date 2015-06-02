using Freelancer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Freelancer.MVC.Models
{
    public class ProjectCreateModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        [DisplayName("Start Price")]
        [Range(0,10000)]   
        public int StartPrice { get; set; }

        [DisplayName("End Price")]
        [Range(0, 10000)]
        public int EndPrice { get; set; }

        [DisplayName("Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}