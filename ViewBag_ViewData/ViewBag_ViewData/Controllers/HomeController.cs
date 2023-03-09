using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Arrays"] = "This is from View Data";
            ViewBag.Massage = "This is from View Bag";
            TempData["Name"] = "This is from Temp Data";
            TempData.Keep();

            string[] games = { "Cricket", "Batmintan", "Football", };
            TempData["GamesList"] = games;

            TempData.Keep();
            return View();
        }

        public ActionResult About()
        {

            return View();
        }
    }
}