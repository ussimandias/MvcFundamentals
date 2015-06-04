using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Infrastructure;

namespace OdeToFood.Controllers
{
    //[Authorize]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        
        //[Authorize(Roles = "Admin" )]
        [Log]      
        //public ActionResult Search(string name)
        //[HttpPost]

        //[HttpGet]
        //[Authorize]
        public ActionResult Search(string name = "*")
        {
            if (name == "*")
            {
                throw new Exception("ooops!");
                //return Json( new { cuisineName = name}, JsonRequestBehavior.AllowGet);
                //return File(Server.MapPath("~/Content/Site.css"), "text/css");
                //return RedirectToAction("Search", "Cuisine", new {name = "French"});
                //return RedirectToRoute("Cuisine", new { name = "Italian" });


            }

            name = Server.HtmlEncode(name);
           
           //return  RedirectToAction("Index", "Home"); // redirects to the index action of home controller
           //return RedirectPermanent("http://www.microsoft.com");
           return Content(name);
           //return Content("You have reached the cuisine controller");
        }

        // GET: Cuisine/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cuisine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cuisine/Create
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

        // GET: Cuisine/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cuisine/Edit/5
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

        // GET: Cuisine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cuisine/Delete/5
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
