using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Freelancer.MVC.Models
{
    public class BidderViewModel
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string AvatarUrl { get; set; }

        public double Rating { get; set; }

        public int Reviews { get; set; }

        public int Bid { get; set; }

        public int TimeInDays { get; set; }
    }
}