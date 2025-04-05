using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Tbl_Slider.ToList();
            return View(values);
        }

        public ActionResult DeleteSlider(int id)
        {
            var values = db.Tbl_Slider.Find(id);
            db.Tbl_Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSlider(Tbl_Slider slider)
        {
            db.Tbl_Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var values = db.Tbl_Slider.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSlider(Tbl_Slider model)
        {
            var value = db.Tbl_Slider.Find(model.SelectID);
            value.NameSurname = model.NameSurname;
            value.Description = model.Description;
            value.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}