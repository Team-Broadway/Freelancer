using Freelancer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Freelancer.MVC.Models
{
    public class ProjectCreateModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        //[IsPriceAfterAttribute("Beginning", ErrorMessage = "Start Price must be less than End Price")]
        public int StartPrice { get; set; }

        public int EndPrice { get; set; }

        public DateTime DueDate { get; set; }

    }
}