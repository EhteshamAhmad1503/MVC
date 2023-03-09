using AjaxBeginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginForm.Controllers
{
    public class HomeController : Controller
    {
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeDemo employee)
        {
            if (ModelState.IsValid == true)
            {
                db.EmployeeDemoes.Add(employee);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    return Json("Data inserted !!");
                }
                else
                {
                    return Json("Data not inserted !!");

                }
            }
            return View();
        }
    }
}