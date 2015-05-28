using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Freelancer.MVC.Models
{
    using System;
    using System.Linq.Expressions;
    using Freelancer.Models;

    public class ProfileViewModel
    {
        public static Expression<Func<User, ProfileViewModel>> ViewModel
        {
            get
            {
                return x => new ProfileViewModel
                {
                    AvatarUrl = x.AvatarUrl,
                    FullName = x.FullName,
                    Info = x.Info,
                    Username = x.UserName,
                    Skills = x.Skills.AsQueryable().Select(SkillViewModel.ViewModel)
                };
            }
        }

        public string Username { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Info { get; set; }

        public IEnumerable<SkillViewModel> Skills { get; set; }
    }
}