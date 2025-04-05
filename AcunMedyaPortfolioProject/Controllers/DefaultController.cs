using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
       
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values = db.Tbl_Service.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            var values = db.Tbl_Contact.ToList();
            return PartialView(values);
        }
        
        public ActionResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            // Başarı mesajını TempData'ya ekleyin
            TempData["SuccessMessage"] = "Mesajınız başarıyla gönderilmiştir.";

            return RedirectToAction("Index");
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.Tbl_Skill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSlider()
        {
            var values = db.Tbl_Slider.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialEducation()
        {
            var values = db.Tbl_Education.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialJobs()
        {
            var values = db.Tbl_Job.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProject()
        {
            var values = db.Tbl_Project.ToList();
            return PartialView(values);
        }

        public ActionResult PartialScript()
        {
            return PartialView();
        }

        public ActionResult PartialHead()
        {
            return PartialView();
        }

        public ActionResult PartialMenu()
        {
            return PartialView();
        }

        public ActionResult PartialFooter()
        {
            return PartialView();
        }
    }
}