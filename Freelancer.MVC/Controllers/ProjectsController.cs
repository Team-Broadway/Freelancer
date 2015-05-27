
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
    public class ProjectsController : BaseController
    {

        public ProjectsController(IFreelancerData data)
            : base(data)
        {
        }


        // GET: Projects
        public ActionResult Index()
        {
            return View(this.Data.Projects.All().ToList());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult List()
        {
            return View(this.Data.Projects.All().ToList());

        }


        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = this.Data.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
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
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,StartPrice,EndPrice,DueDate,IsOpen,MaxExperience")] Project project)
        {
            if (ModelState.IsValid)
            {
                Data.Projects.Add(project);
                Data.SaveChanges();
                this.AddNotification("Project created.", NotificationType.SUCCESS);
                return RedirectToAction("Index");
            }

            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = this.Data.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

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
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = this.Data.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

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
    }
}
