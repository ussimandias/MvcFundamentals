using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;

namespace OdeToFood.Controllers
{
    public class RestaurantController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        // GET: Restaurant
        public ActionResult Index(string state)
        {
            ViewBag.States = _db.Restaurants.Select(r=> r.Address.State).Distinct();

            var model =
                _db.Restaurants
                .OrderByDescending(r => r.Address.City)
                .Where(r => r.Address.State == state || (state == null));

            //var model = from r in _db.Restaurants
            //            orderby r.Address.City
            //            where r.Address.State == state || (state == null)
            //            select r;

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _db.Restaurants.Single(r => r.ID == id);

            return View(model);
        }


        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    var review = _db.Reviews.FindById(id);
        //    return View(review);


        //}

        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    var review = _db.Reviews.FindById(id);

        //    if (TryUpdateModel(review))
        //    {
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    // TODO: Add update logic here

        //    return View(review);

            
        //}
    }
}