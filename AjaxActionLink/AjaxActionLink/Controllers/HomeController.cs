using AjaxActionLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxActionLink.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployees()
        {
            var data = db.Employees.ToList();
            return PartialView("EmployeeData", data);
        }
        public ActionResult TopDetails()
        {
            var data = db.Employees.OrderByDescending(model => model.FirstName).Take(3).ToList();
            return PartialView("EmployeeData", data);
        }
        public ActionResult TopSalary()
        {
            var data = db.Employees.OrderBy(model => model.Salary).Take(5).ToList();
            return PartialView("EmployeeData", data);
        }
    }
}