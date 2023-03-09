using AjexHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjexHelper.Controllers
{
    public class HomeController : Controller
    {
        InformationEntities db = new InformationEntities();
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        [HttpPost]
        public ActionResult Index(string Find)
        {
            if (string.IsNullOrEmpty(Find) == false)
            {
                List<Student> students = db.Students.Where(model => model.Name.StartsWith(Find)).ToList();
                return PartialView("_SearchData", students);
            }
            else
            {
                List<Student> students = db.Students.ToList();
                return PartialView("_SearchData", students);
            }
        }
    }
}