using System;
using System.Linq.Expressions;
using Freelancer.Models;

namespace Freelancer.MVC.Models
{
    public class SkillViewModel
    {
        public static Expression<Func<Skill, SkillViewModel>> ViewModel
        {
            get
            {
                return x => new SkillViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}