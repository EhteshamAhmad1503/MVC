using StronglyType_HTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyType_HTMLHelpers.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculation calculation)
        {
            int a = calculation.Num;
            int b = calculation.Num1;
            int Result = a + b;
            ViewBag.Calculate = Result;

            return View();
        }
    }
}