using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class BiddingProjectEmployee
    {

        [Key, Column(Order = 0)]
        public int ProjectId { get; set; }

        [Key, Column(Order = 1)]
        public string EmployeeId { get; set; }

        public virtual Project Project { get; set; }

        public virtual User Employee { get; set; }
        [Range(0,10000)]
        public int Bid { get; set; }
    }
}
