using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Freelancer.MVC.Models
{
    public class BidModel
    {
        [Range(0,10000)]
        [DisplayName("Bid")]
        public int Price { get; set; }

        [Range(0, 10000)]
        [DisplayName("Deliver in")]
        public int Days { get; set; }
    }
}