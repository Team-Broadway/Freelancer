using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelancer.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string QuestionTitle { get; set; }

        public string Answer_First { get; set; }

        public string Answer_Second { get; set; }

        public string Answer_Third { get; set; }

        public string Answer_Correct { get; set; }

        public int Points { get; set; }
    }
}
