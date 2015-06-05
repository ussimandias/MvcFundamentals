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
        OdeToFoodDb _db = new OdeToFoodDb();

        // GET: Restaurant
        public ActionResult Index()
        {
            var model = _db.Restaurants;

            return View(model);
        }
    }
}