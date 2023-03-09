using MVCUpdateEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUpdateEntity.Controllers
{
    public class HomeController : Controller
    {
        EmployeesDBEntities DB = new EmployeesDBEntities();
        public ActionResult Index()
        {
            var data = DB.Students.ToList();
            return View(data);
        }
        public ActionResult Employee()
        {
            var data = DB.Employees.ToList();
            return View(data);
        }
    }
}