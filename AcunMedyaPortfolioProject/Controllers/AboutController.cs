using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;


namespace AcunMedyaPortfolioProject.Controllers
{
    
    public class AboutController : Controller
    {
        // GET: About
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Tbl_About.ToList();
            return View(values);
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            db.Tbl_About.Remove(values);
            db.SaveChanges(); // SQL deki ctrl+s
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(Tbl_About about)
        {
            db.Tbl_About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.Tbl_About.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAbout(Tbl_About about)
        {
            var value = db.Tbl_About.Find(about.AboutID);
            value.ImageUrl = about.ImageUrl;
            value.Title = about.Title;
            value.Birthday = about.Birthday;
            value.WebSite = about.WebSite;  
            value.Phone = about.Phone;
            value.City = about.City;    
            value.Age = about.Age;
            value.Email = about.Email;  
            value.Freelance = about.Freelance;
            value.Description1 = about.Description1;    
            value.Description2 = about.Description2;    
            value.Degree = about.Degree;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}