using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDATA_MVC.Models;

namespace ViewDATA_MVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            string[] Name = { "Faiyaz", "Abdullah", "Gulam", "Irfan", "Ehtesham" };
            ViewData["NameList"] = Name;

            ViewData["Sports"] = new List<string>
            {
                "Cricket",
                "Hockey",
                "Football",
                "Batmintan",
                "Kabaddi"
            };

            Student s = new Student();
            s.StdID = 101;
            s.StdName = "Ehtesham";
            s.StdClass = "MCA";

            ViewData["Student"] = s;

            return View();
        }
    }
}