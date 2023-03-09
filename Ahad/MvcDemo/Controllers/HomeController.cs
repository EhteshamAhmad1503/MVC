using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           ViewBag.Countries = new  List<string>()
            {
                "India",
                "Australiya",
                "England"
            };
            return View();
        }
             
        }
    }
