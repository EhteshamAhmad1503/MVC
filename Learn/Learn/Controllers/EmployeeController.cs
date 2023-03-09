using Learn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int Id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Introduction introduction = employeeContext.Introductions.Single(ins => ins.Id == Id);

            return View(introduction);
        }
    }
}