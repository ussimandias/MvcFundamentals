using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult JsonSearch(string q)
        {
            var restaurants = _db.Restaurants
                .Where(r => r.Name.Contains(q) || String.IsNullOrEmpty(q))
                .Take(10)
                .Select(r => new
                {
                    r.Name,
                    r.Address.City,
                    r.Address.Country
                });
            return Json(restaurants, JsonRequestBehavior.AllowGet);
        }

        public ActionResult QuickSearch(string term)
        {
            var restaurants = _db.Restaurants
                .Where(r => r.Name.Contains(term))
                .Take(10)
                .Select(r => new {label = r.Name});

            return Json(restaurants, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult Search(string q)
        {
            var restaurants = _db.Restaurants
                .Where(r => r.Name.Contains(q) || string.IsNullOrEmpty(q))
                .Take(10);

            return PartialView("_RestaurantSearchResults", restaurants);
        }

        public PartialViewResult LatestReview()
        {
            Thread.Sleep(2000);
            var review = _db.Reviews.FindTheLatest(1).Single();
            return PartialView("_Review", review);
        }

        public ViewResult Index()
        {
            ViewBag.Message = string.Format("{0}::{1} {2}", RouteData.Values["controller"], RouteData.Values["action"], RouteData.Values["id"]);

            var model = new Review()
            {
                Name = "Madiba",
                Rating = 8

            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}