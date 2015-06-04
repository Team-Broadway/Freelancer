using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Freelancer.MVC.Models
{
    using System;
    using System.Linq.Expressions;
    using Freelancer.Models;
    using Freelancer.Common.Mappings;

    public class ProfileViewModel //: IMapFrom<User>
    {
        public string Username { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Info { get; set; }

        public IEnumerable<SkillViewModel> Skills { get; set; }
    }
}