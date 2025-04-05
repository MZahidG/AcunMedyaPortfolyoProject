using AcunMedyaPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();

        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.Tbl_Category.Count();
            ViewBag.TestimonialCount = db.Tbl_Testimonial.Count();
            ViewBag.ProjectCount = db.Tbl_Project.Count();
            ViewBag.JobsCount = db.Tbl_Job.Count();
            ViewBag.SkillCount = db.Tbl_Skill.Count();
            ViewBag.ServicesCount = db.Tbl_Service.Count();
            ViewBag.MessageCount = db.Tbl_Message.Count();
            ViewBag.EducationCount = db.Tbl_Education.Count();

            // Yeni Eklemeler
            ViewBag.LastProject = db.Tbl_Project.OrderByDescending(p => p.ProjectID).Select(p => p.ProjectName).FirstOrDefault();
            ViewBag.LastMessage = db.Tbl_Message.OrderByDescending(c => c.MessageID).Select(c => c.MessageContent).FirstOrDefault();
            ViewBag.LastService = db.Tbl_Service.OrderByDescending(s => s.ServiceID).Select(s => s.Title).FirstOrDefault();
            ViewBag.LastSkill = db.Tbl_Skill.OrderByDescending(s => s.SkillID).Select(s => s.SkillName).FirstOrDefault();
            ViewBag.LastTestimonial = db.Tbl_Testimonial.OrderByDescending(t => t.TestimonialID).Select(t => t.TestimonialName).FirstOrDefault();
            ViewBag.LastJob = db.Tbl_Job.OrderByDescending(j => j.JobID).Select(j => j.Title).FirstOrDefault();
            ViewBag.LastEducation = db.Tbl_Education.OrderByDescending(e => e.EducationID).Select(e => e.Name).FirstOrDefault();

            return View();
        }
    }
}