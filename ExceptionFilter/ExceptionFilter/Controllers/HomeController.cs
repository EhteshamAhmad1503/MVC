using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }
        [HandleError(View = "Error2")]
        public ActionResult About()
        {
            throw new Exception();
            return View();
        }
    }
}