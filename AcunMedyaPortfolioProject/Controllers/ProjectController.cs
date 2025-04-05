using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Tbl_Project.ToList();
            return View(values);
        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(values);
            db.SaveChanges(); // SQL deki ctrl+s
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(Tbl_Project project)
        {
            db.Tbl_Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            return View(values);
        }

        public ActionResult UpdateProject(Tbl_Project model)
        {
            var value = db.Tbl_Project.Find(model.ProjectID);
            value.ProjectName = model.ProjectName;
            value.Description = model.Description;
            value.ProjectUrl = model.ProjectUrl;
            value.Image1 = model.Image1;
            value.Image2 = model.Image2;
            value.Image3 = model.Image3;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}