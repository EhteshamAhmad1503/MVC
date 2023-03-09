using Stronly_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stronly_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee employee = new Employee();

            employee.EmpID = 101;
            employee.Employee_Name = "Ehtesham Ahmmad";
            employee.Designation = "Junior Software Engineer";
            employee.Salary = 50000;

            Employee employee1 = new Employee();

            employee1.EmpID = 102;
            employee1.Employee_Name = "Irfan Ansari";
            employee1.Designation = "Junior Software Engineer";
            employee1.Salary = 55000;

            Employee employee2 = new Employee();

            employee2.EmpID = 103;
            employee2.Employee_Name = "Gulam Sarwar";
            employee2.Designation = " Software Engineer";
            employee2.Salary = 60000;

            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee);
            employeesList.Add(employee1);
            employeesList.Add(employee2);

            ViewData["Information"] = employee;
            ViewBag.Data = employee;

            return View(employeesList);
        }
    }
}