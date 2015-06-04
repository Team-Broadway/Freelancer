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
        public int ProjectId { get; set; }

        [Range(0,10000)]
        public int Bid { get; set; }

        [Range(0, 10000)]
        [DisplayName("Delivery")]
        public int TimeInDays { get; set; }
    }
}