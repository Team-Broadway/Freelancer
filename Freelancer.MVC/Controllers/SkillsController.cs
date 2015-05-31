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
    public class SkillsController : BaseController
    {
        
        public SkillsController(IFreelancerData data)
            :base(data)
        {
        }

        // GET: Skills
        public ActionResult Index()
        {
            return View(Data.Skills.All().ToList());
        }

        // GET: Skills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill skill = Data.Skills.Find(id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            return View(skill);
        }

        // GET: Skills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Skills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Skill skill)
        {
            if (ModelState.IsValid)
            {
                Data.Skills.Add(skill);
                Data.SaveChanges();
                this.AddNotification("Skill created.", NotificationType.SUCCESS);
                return RedirectToAction("Index");
            }

            return View(skill);
        }

        // GET: Skills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill skill = Data.Skills.Find(id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            return View(skill);
        }

        // POST: Skills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Skill skill)
        {
            if (ModelState.IsValid)
            {
                this.Data.Skills.Update(skill);
                Data.SaveChanges();
                this.AddNotification("Skill edited successfully.", NotificationType.SUCCESS);
                return RedirectToAction("Index");
            }
            return View(skill);
        }

        // GET: Skills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill skill = Data.Skills.Find(id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            return View(skill);
        }

        // POST: Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skill skill = Data.Skills.Find(id);
            Data.Skills.Delete(skill);
            Data.SaveChanges();
            this.AddNotification("Skill deleted successfully.", NotificationType.SUCCESS);
            return RedirectToAction("Index");
        }
    }
}
