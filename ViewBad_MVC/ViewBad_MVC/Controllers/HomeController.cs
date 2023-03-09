using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBad_MVC.Models;

namespace ViewBag_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.massage = "This is Ehtesham";
            ViewBag.current = DateTime.Now;

            string[] fruits = { "Apple", "Orange", "Grappes", "Mango", "Watermelon" };
            ViewBag.FruitsList = fruits;

            ViewBag.Sports = new List<string>
            {
                "Cricket",
                "Football",
                "Batmintan",
                "Basketball",
                "kabaddi"
            };

            Employee emp = new Employee();
            emp.EmpID = 101;
            emp.EmpName = "Ehtesham";
            emp.EmpDesignation = "Software Engineer";
            emp.EmpDepartment = "IT";

            ViewBag.employee = emp;
            return View();
        }
    }
}