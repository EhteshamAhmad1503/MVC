using Instagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Instagram.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        EmployeeDBEntities employeeDB = new EmployeeDBEntities();
        public ActionResult Index()
        {
            List<User> data = employeeDB.Users.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            employeeDB.Users.Add(user);
            employeeDB.SaveChanges();
            return View();
        }
    }
}