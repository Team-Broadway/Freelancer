using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Freelancer.Models
{
    public class Review
    {
        public int Id { get; set; }

        public virtual User Author { get; set; }

        public string Message { get; set; }

        [Required]
        [Range(1,10)]
        public int Rating { get; set; }
    }
}
