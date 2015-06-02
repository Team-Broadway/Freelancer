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
    using Freelancer.Data;
    using Freelancer.Models;
    using Freelancer.Data.UnitOfWork;
    using Freelancer.MVC.Extensions;
    using Freelancer.MVC.Models;
    using AutoMapper;

    public class ProjectsController : BaseController
    {

        public ProjectsController(IFreelancerData data)
            : base(data)
        {
        }


        // GET: Projects
        public ActionResult Index()
        {
            IEnumerable<ProjectViewModel> model;

            var projects = this.Data.Projects.All().ToList();

            Mapper.CreateMap<Project, ProjectViewModel>()
                .ForMember(x => x.Bids, o => o.MapFrom(x => x.BiddingProjectEmployee.Count))
                .ForMember(x => x.Skills, o => o.MapFrom(so => so.Skills.Select(t => t.Name).ToList()))
                .ForMember(x => x.Price, o => o.MapFrom(s =>  s.StartPrice.ToString() + " - " + s.EndPrice.ToString() + " BGN"))
                .ForMember(x => x.StartDate, o => o.MapFrom(s => s.StartDate.Date == DateTime.Now.Date ? "Today" : s.StartDate.ToShortDateString()));


            model = Mapper.Map<ICollection<Project>, IEnumerable<ProjectViewModel>>(projects);

            return View(model);
        }

        //[Authorize(Roles = "Admin")]
        //public ActionResult List()
        //{
        //    return View(this.Data.Projects.All().ToList());

        //}

     
        public ActionResult Details(int? id,string bid)
        {

            ProjectDetailedViewModel model;

            Mapper.CreateMap<Project, ProjectDetailedViewModel>()
               .ForMember(x => x.Bids, o => o.MapFrom(x => x.BiddingProjectEmployee.Count))
               .ForMember(x => x.Skills, o => o.MapFrom(so => so.Skills.Select(t => t.Name).ToList()))
               .ForMember(x => x.Price, o => o.MapFrom(s => s.StartPrice.ToString() + " - " + s.EndPrice.ToString() + " BGN"))
               .ForMember(x => x.StartDate, o => o.MapFrom(s => s.StartDate.Date == DateTime.Now.Date ? "Today" : s.StartDate.ToShortDateString()))
               .ForMember(x => x.StartDate, o => o.MapFrom(s => s.DueDate.Date.ToShortDateString()));

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Project project = this.Data.Projects.Find(id);
            model = Mapper.Map<Project, ProjectDetailedViewModel>(project);

            if (bid == "true")
            {
                model.BidMenuOpen = true;
            }

            if (project == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult DetailsForAdmin(int id)
        {
            Project project = this.Data.Projects.Find(id);
            return View("Details", project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            var skills = this.Data.Skills.All().ToList();
            return View(skills);
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,StartPrice,EndPrice,DueDate")] Project project, HashSet<string> SelectedSkills)
        {
            if (ModelState.IsValid && project.StartPrice <= project.EndPrice)
            {
                project.Employer = this.UserProfile;
                project.StartDate = DateTime.Now;
                if (SelectedSkills != null)
                {
                    foreach (string skill in SelectedSkills)
                    {
                        project.Skills.Add(this.Data.Skills.Find(Int32.Parse(skill)));
                    }
                }
                this.Data.Projects.Add(project);
                this.Data.SaveChanges();
                this.AddNotification("Project created.", NotificationType.SUCCESS);
            }
            else
            {
                this.AddNotification("Project error.", NotificationType.ERROR);
            }
            return RedirectToAction("Index");
        }

        // GET: Projects/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Project project = this.Data.Projects.Find(id);
        //    if (project == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(project);
        //}

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Projects/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Project project = this.Data.Projects.Find(id);
        //    if (project == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(project);
        //}

        // POST: Projects/Delete/5
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
        [Authorize]
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
    }
}
