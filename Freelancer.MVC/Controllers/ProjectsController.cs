namespace Freelancer.MVC.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using PagedList;
    using Freelancer.Data;
    using Freelancer.Models;
    using Freelancer.Data.UnitOfWork;
    using Freelancer.MVC.Extensions;
    using Freelancer.MVC.Models;
    using AutoMapper;
    using Microsoft.AspNet.SignalR;
    using Twitter.MVC.Hubs;

    [System.Web.Mvc.Authorize]
    public class ProjectsController : BaseController
    {
        private const int pageSize = 10;
        public ProjectsController(IFreelancerData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id,string bid)
        {
            ProjectDetailedViewModel model;

            Mapper.CreateMap<Project, ProjectDetailedViewModel>()
               .ForMember(x => x.Bids, o => o.MapFrom(x => x.BiddingProjectEmployee.Count))
               .ForMember(x => x.Skills, o => o.MapFrom(so => so.Skills.Select(t => t.Name).ToList()))
               .ForMember(x => x.Price, o => o.MapFrom(s => s.StartPrice.ToString() + " - " + s.EndPrice.ToString() + " BGN"))
               .ForMember(x => x.StartDate, o => o.MapFrom(s => s.StartDate.Date == DateTime.Now.Date ? "Today" : s.StartDate.ToShortDateString()))
               .ForMember(x => x.DueDate, o => o.MapFrom(s => s.DueDate.Date.ToShortDateString()));

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Project project = this.Data.Projects.Find(id);
            model = Mapper.Map<Project, ProjectDetailedViewModel>(project);

            if (project == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectCreateModel project, HashSet<string> SelectedSkills)
        {
            if (ModelState.IsValid && project.StartPrice <= project.EndPrice 
                && project.DueDate.Date >= DateTime.Now.Date)
            {
                Mapper.CreateMap<ProjectCreateModel, Project>();
                Project newProject = Mapper.Map<ProjectCreateModel, Project>(project);

                newProject.Employer = this.UserProfile;
                newProject.StartDate = DateTime.Now;

                if (SelectedSkills != null)
                {
                    foreach (string skill in SelectedSkills)
                    {
                        newProject.Skills.Add(this.Data.Skills.Find(Int32.Parse(skill)));
                    }
                }
                this.Data.Projects.Add(newProject);
                this.Data.SaveChanges();
                this.AddNotification("Project created.", NotificationType.SUCCESS);
                var myHub = GlobalHost.ConnectionManager.GetHubContext<ProjectsHub>();
                myHub.Clients.All.addProjectsHubMessage(newProject.Id);
            }
            else
            {
                this.AddNotification("Project error.", NotificationType.ERROR);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,StartPrice,EndPrice,DueDate,IsOpen,MaxExperience")] Project project)
        {
            if (ModelState.IsValid)
            {
                this.Data.Projects.Update(project);
                this.Data.SaveChanges();
                this.AddNotification("Project edited.", NotificationType.SUCCESS);
                return RedirectToAction("Index");
            }
            return View(project);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = this.Data.Projects.Find(id);
            Data.Projects.Delete(project);
            Data.SaveChanges();
            this.AddNotification("Project deleted.", NotificationType.SUCCESS);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("bookmark/{id:int}")]
        public JsonResult Bookmark(int id)
        {
            var project = this.Data.Projects.Find(id);
            bool result;
            if(UserProfile.BookmarkedProjects.Any(p => p.Id == id))
            {
                UserProfile.BookmarkedProjects.Remove(project);
                result = false;
            }
            else
            {
                UserProfile.BookmarkedProjects.Add(project);
                result = true;
            }
            
            this.Data.SaveChanges();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //Ajax only
        public ActionResult List(int? page)
        {
            if (!this.HttpContext.Request.IsAjaxRequest())
            {
                return RedirectToAction("Index");
            }
            int pageNumber = (page ?? 1);

            IEnumerable<ProjectViewModel> model;

            var projects = this.Data.Projects.All().OrderByDescending(p => p.StartDate).ToList();

            Mapper.CreateMap<Project, ProjectViewModel>()
                .ForMember(x => x.Bids, o => o.MapFrom(x => x.BiddingProjectEmployee.Count))
                .ForMember(x => x.Skills, o => o.MapFrom(so => so.Skills.Select(t => t.Name).ToList()))
                .ForMember(x => x.Price, o => o.MapFrom(s => s.StartPrice.ToString() + " - " + s.EndPrice.ToString() + " BGN"))
                .ForMember(x => x.StartDate, o => o.MapFrom(s => s.StartDate.Date == DateTime.Now.Date ? "Today" : s.StartDate.ToShortDateString()));

            model = Mapper.Map<ICollection<Project>, IEnumerable<ProjectViewModel>>(projects);

            return PartialView("_ProjectList", model.ToPagedList(pageNumber, pageSize));
        }

        //Ajax only
        public ActionResult LoadBidMenu(int projectId)
        {
            if(!this.HttpContext.Request.IsAjaxRequest())
            {
                return RedirectToAction("Index");
            }
            return this.PartialView("_BidMenu", new BidModel { ProjectId = projectId });
        }

        //Ajax only
        public ActionResult LoadBidders(int projectId)
        {
            if (!this.HttpContext.Request.IsAjaxRequest())
            {
                return RedirectToAction("Index");
            }

            var bpe = this.Data.BiddingProjectEmployees.All()
                .Where(b => b.ProjectId == projectId)
                .OrderByDescending(b => b.BidDate)
                .ToList();

            Mapper.CreateMap<BiddingProjectEmployee, BidderViewModel>()
                .ForMember(u => u.Reviews, a => a.MapFrom(c => c.Employee.Reviews.Count()))
                .ForMember(u => u.Rating, a => a.MapFrom(c => c.Employee.Reviews.Count() == 0 ?
                    0 : (c.Employee.Reviews.Select(r => r.Rating).Sum() / c.Employee.Reviews.Count())))
                .ForMember(u => u.UserName, a => a.MapFrom(c => c.Employee.UserName))
                .ForMember(u => u.UserId, a => a.MapFrom(c => c.Employee.Id))
                .ForMember(u => u.AvatarUrl, a => a.MapFrom(c => c.Employee.AvatarUrl));

            var model = Mapper.Map<ICollection<BiddingProjectEmployee>, IEnumerable<BidderViewModel>>(bpe);
            return this.PartialView("_BidderList", model);
        }

        //Ajax only
        public ActionResult ProjectRowPartial(int id)
        {
            if (!this.HttpContext.Request.IsAjaxRequest())
            {
                return RedirectToAction("Index");
            }

            Project project = this.Data.Projects.Find(id);

            Mapper.CreateMap<Project, ProjectViewModel>()
            .ForMember(x => x.Bids, o => o.MapFrom(x => x.BiddingProjectEmployee.Count))
            .ForMember(x => x.Skills, o => o.MapFrom(so => so.Skills.Select(t => t.Name).ToList()))
            .ForMember(x => x.Price, o => o.MapFrom(s => s.StartPrice.ToString() + " - " + s.EndPrice.ToString() + " BGN"))
            .ForMember(x => x.StartDate, o => o.MapFrom(s => s.StartDate.Date == DateTime.Now.Date ? "Today" : s.StartDate.ToShortDateString()));

            ProjectViewModel model = Mapper.Map<Project, ProjectViewModel>(project);

            return this.PartialView("_ProjectRow", model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Bid(BidModel model)
        {
            var project = this.Data.Projects.Find(model.ProjectId);
            if(project.Employer.Id == UserProfile.Id)
            {
                this.AddNotification("You cannot bid on your own project", NotificationType.ERROR);
                return RedirectToAction("Details", new { id = model.ProjectId });
            }

            if (project.BiddingProjectEmployee.Any(b => b.Employee.Id == UserProfile.Id))
            {
                this.AddNotification("You have already bid on this project", NotificationType.ERROR);
                return RedirectToAction("Details", new { id = model.ProjectId });
            }

            if (ModelState.IsValid)
            {
                Mapper.CreateMap<BidModel, BiddingProjectEmployee>();
                BiddingProjectEmployee bpe = Mapper.Map<BidModel, BiddingProjectEmployee>(model);
                bpe.BidDate = DateTime.Now;
                bpe.EmployeeId = UserProfile.Id;

                this.Data.BiddingProjectEmployees.Add(bpe);
                this.Data.SaveChanges();
                this.AddNotification("Successfully bid", NotificationType.SUCCESS);
            }
            else
            {
                this.AddNotification("Error bidding", NotificationType.ERROR);
            }
            return RedirectToAction("Details", new { id = model.ProjectId });
        }

    }
}
