using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionLink_Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }public ActionResult About()
        {
            return View();
        }public ActionResult Contect()
        {
            return View();
        }
    }
}