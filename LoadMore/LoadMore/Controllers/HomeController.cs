using LoadMore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoadMore.Controllers
{
    public class HomeController : Controller
    {
        DetailsEntities db = new DetailsEntities();
        public ActionResult Index()
        {
            int num = 5;
            Session["Data"] = num;
            var data = db.People.ToList().Take(num);
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            int row = Convert.ToInt32(Session["Data"]) + 5;
            var data = db.People.ToList().Take(row);
            Session["Data"] = row;
            return PartialView("_PersonData", data);
        }
    }
}