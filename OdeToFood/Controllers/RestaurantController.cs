using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant

        OdeToFoodDB _db = new OdeToFoodDB();

        public ActionResult Index()
        {
            var model = _db.Restaurants;

            //LINQ Comprehensive Query
            //var model = from r in _db.Restaurants
            //            //orderby r.Name
            //            select r;
            
            //Lambda Expression
            //var model =
            //    _db.Restaurants
            //        .OrderByDescending(r => r.ChefsName)
            //        .Select(r => r.ChefsName);
               

            return View();
            //return View();
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            _db.Restaurants.Find(id);

            return View();
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
