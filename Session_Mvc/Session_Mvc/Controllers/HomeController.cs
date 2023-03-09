using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session_Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["var"]  = "This is View Data";
            ViewBag.var1     = "This is View Bag";
            TempData["var2"] = "This is Temp Data";
            Session["var3"]  = "This is Session Data";

            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contect()
        {
            return View();
        }
    }
}