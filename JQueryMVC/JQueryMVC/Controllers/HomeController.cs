using JQueryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryMVC.Controllers
{
    public class HomeController : Controller
    {
        DetailsDBEntities db = new DetailsDBEntities();
        public ActionResult Index()
        {
            var data = db.People.ToList();
            return View(data);
        }
    }
}