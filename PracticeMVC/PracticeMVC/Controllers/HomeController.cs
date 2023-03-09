using PracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVC.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            var data = db.SaveChanges();
            if (data < 0)
            {
                ViewData["Message"] = "Data has been inserted successfully";
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}