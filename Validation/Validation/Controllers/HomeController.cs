﻿using System.Web.Mvc;
using Validations.Models;

namespace Validations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Employee employee)
        {
            return View();
        }
    }
}