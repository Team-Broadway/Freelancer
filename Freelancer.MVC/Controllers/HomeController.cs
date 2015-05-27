using System.Data.Entity;
using Freelancer.Data;
using Freelancer.Data.Migrations;

namespace Freelancer.MVC.Controllers
{
    using Freelancer.Data.UnitOfWork;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public HomeController(IFreelancerData data)
            :base(data)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public ActionResult Index()
        {
            return View();
        }

<<<<<<< .mine
        public JsonResult CheckUsername(string Username)
        {
            bool userExists = this.Data.Users.All().Any(u => u.UserName == Username);
            if(userExists)
            {
                return Json(false,JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }
=======
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
>>>>>>> .r10
    }
}