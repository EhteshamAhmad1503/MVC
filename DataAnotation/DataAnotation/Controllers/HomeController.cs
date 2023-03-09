using DataAnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnotation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMassage"] = "Data updataed Successfully";
                ModelState.Clear();
            }

            return View();
        }
    }
}