namespace Freelancer.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TestStack.FluentMVCTesting;

    using Freelancer.MVC.Controllers;
    using Freelancer.Data;
    using Freelancer.Data.UnitOfWork;
    //using Freelancer.MVC.Infrastructure.CacheService;

    [TestClass]
    public class ProjectControllerTests
    {
        [TestMethod]
        public void TestIndexAction_ShouldReturnDefaultView()
        {
            var data = new FreelancerData(new ApplicationDbContext());
            var controller = new ProjectsController(data);
            controller.WithCallTo(x => x.Index())
                .ShouldRenderDefaultView();
        }

        [TestMethod]
        public void TestCrateAction_ShouldReturnFull()
        {
            var data = new FreelancerData(new ApplicationDbContext());
            var controller = new ProjectsController(data);
            controller.WithCallTo(x => x.Details(4,""))
                .ShouldRenderView("Details");
        }


        [TestMethod]
        public void TestDeleteAction_ShouldReturnToIndex()
        {
            var data = new FreelancerData(new ApplicationDbContext());
            var controller = new ProjectsController(data);
            controller.WithCallTo(x => x.DeleteConfirmed(4))
                .ShouldRedirectTo("Index");
        }

        [TestMethod]
        public void FindById_ShouldReturnNull()
        {
            var data = new FreelancerData(new ApplicationDbContext());
            var controller = new ProjectsController(data);
            controller.WithCallTo(x => x.Details(4, ""))
                .ShouldReturnEmptyResult();
        }
    }
}
