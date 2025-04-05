using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolioProject.Models;

namespace AcunMedyaPortfolioProject.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        DbAcunMedyaProject1Entities2 db = new DbAcunMedyaProject1Entities2();
        public ActionResult Index()
        {
            var values = db.Tbl_Category.ToList();
            return View(values);
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(values);
            db.SaveChanges(); // SQL deki ctrl+s
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Tbl_Category category)
        {
            db.Tbl_Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.Tbl_Category.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category model)
        {
            var value = db.Tbl_Category.Find(model.CategoryID);
            value.CategoryName = model.CategoryName;
            db.SaveChanges();  //ctrl s veri tabanında
            return RedirectToAction("Index");
        }
    }


}