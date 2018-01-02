using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFinalProject.Models;

namespace CodeFinalProject.Controllers
{
    public class HomeController : Controller
    {
        Black_fridayEntities1 db = new Black_fridayEntities1();
        public ActionResult Index()
        {
            ViewBag.category = db.categories.ToList();

            ViewBag.BlogProduct = db.products.ToList().Where(p => p.name == "blog");
            ViewBag.coupons = db.products.ToList().Where(p => p.name == "coupons");
            ViewBag.partners = db.images.ToList().Where(p => p.page == "partners");
            ViewBag.sale = db.sales.ToList().Where(p => p.name == "black-friday");
            ViewBag.latestDeals = db.products.ToList().Where(p => p.name == "latest-deals");
            ViewBag.popular = db.images.ToList().Where(p => p.page == "popular");
            ViewBag.trending= db.products.ToList().Where(p => p.name == "trend");
            return View();
        }

      
    }
}