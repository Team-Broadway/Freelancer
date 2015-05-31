namespace Freelancer.MVC.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Freelancer.Data.UnitOfWork;
    using System;
    using Freelancer.MVC.Models;
    using AutoMapper;
    using Freelancer.Models;

    public class UsersController : BaseController
    {
        public UsersController(IFreelancerData data)
            :base(data)
        {
        }

        // GET: Users
        public ActionResult Index(string username)
        {
            var user = this.Data.Users
                .All()
                .Where(x => x.UserName == username)
                .FirstOrDefault();

            if (user == null)
            {
                return this.HttpNotFound(String.Format("User \"{0}\" doesn't exists!", username));
            }

            Mapper.CreateMap<User, UserViewModel>();
            var userViewModel = Mapper.Map<User, UserViewModel>(user);

            return this.View(userViewModel);
        }
    }
}