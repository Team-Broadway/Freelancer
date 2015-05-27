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
    }
}