using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2 ();
        public ActionResult Index()
        {
            var values = db.Tbl_Job.ToList();
            return View(values);
        }
        public ActionResult DeleteJob(int id)
        {
            var values = db.Tbl_Job.Find(id);
            db.Tbl_Job.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateJob()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateJob(Tbl_Job job)
        {
            db.Tbl_Job.Add(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateJob(int id)
        {
            var values = db.Tbl_Job.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateJob(Tbl_Job model)
        {
            var value = db.Tbl_Job.Find(model.JobID);
            value.Title = model.Title;
            value.StartDate = model.StartDate;
            value.EndDate = model.EndDate;
            value.CompanyName = model.CompanyName;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}