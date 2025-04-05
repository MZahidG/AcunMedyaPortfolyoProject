using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Tbl_Service.ToList();
            return View(values);
        }

        public ActionResult DeleteServices(int id)
        {
            var values = db.Tbl_Service.Find(id);
            db.Tbl_Service.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateServices(Tbl_Service sevices)
        {
            db.Tbl_Service.Add(sevices);
            db.SaveChanges();
            return RedirectToAction("Index");
           
        }
        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = db.Tbl_Service.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateServices(Tbl_Service model)
        {
            var value = db.Tbl_Service.Find(model.ServiceID);
            value.Description = model.Description;
            value.Title = model.Title;
            value.IconUrl = model.IconUrl;
            value.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}