using ResultFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultFilter.Controllers
{
    public class HomeController : Controller
    {
        DetailsEntities db = new DetailsEntities();

        [OutputCache(Duration = 20)]
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }
        [OutputCache(Duration = 20)]
        public ActionResult Details()
        {
            var data = db.People.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }

        [OutputCache(Duration = 10)]
        public ActionResult Create(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Details");
        }


    }
}