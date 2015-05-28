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
                    Username = x.UserName
                };
            }
        }

        public string Username { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Info { get; set; }
    }
}