using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;



namespace AcunMedyaPortfolioProject.Controllers
{
    public class EducationController : Controller
    {
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        // GET: Education
            public ActionResult Index()
        {
            var values = db.Tbl_Education.ToList();
            return View(values);
        }
        public ActionResult DeleteEducation(int id)
        {
            var values =db.Tbl_Education.Find(id);
            db.Tbl_Education.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        public ActionResult CreateEducation(Tbl_Education education)
        {
            db.Tbl_Education.Add(education);
            db.SaveChanges();   
            return RedirectToAction("Index");
        }
        [HttpGet]

        public ActionResult UpdateEducation(int id)
        {
            var values = db.Tbl_Education.Find(id);
            return View(values);
        }

        [HttpPost]

        public ActionResult UpdateEducation(Tbl_Education model)
        {
            var value = db.Tbl_Education.Find(model.EducationID);
            value.Name = model.Name;
            value.StartYear = model.StartYear;
            value.EndYear = model.EndYear;
            value.Section = model.Section;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}