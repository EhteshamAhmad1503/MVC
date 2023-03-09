using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag.Models;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Footbal",
                "Hockey",
                "BatMinton"
            };

            Employee emp = new Employee();

            emp.ID = 101;
            emp.FirstName = "Ehtesham";
            emp.LastName = "Ahmad";
            emp.Gender = "Male";
            emp.Salary = 500000;
            ViewBag.Data = emp;
            return View();
        }
    }
}