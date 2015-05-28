using Freelancer.MVC.Models;

namespace Freelancer.MVC.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Freelancer.Data.UnitOfWork;

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
                .FirstOrDefault(x => x.UserName == username);

            var outputUser = new ProfileViewModel
            {
                Username = user.UserName,
                FullName = user.FullName,
                Info = user.Info,
                AvatarUrl = user.AvatarUrl
            };

            return this.View(outputUser);
        }
    }
}