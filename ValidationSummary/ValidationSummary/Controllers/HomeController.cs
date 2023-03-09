using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ValidationSummary.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        string EmailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string FullName, string Age, string Email)
        {
            if (FullName.Equals("") == true)
            {
                ModelState.AddModelError("FullName", "FullName is required!!");
                ViewData["FullNameError"] = "*";
            }

            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is required!!!");
                ViewData["AgeError"] = "*";
            }

            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is required!!!");
                ViewData["EmailError"] = "*";
            }
            else
            {
                if (Regex.IsMatch(Email, EmailPattern) == false)
                {
                    ModelState.AddModelError("Email", "Invalid Email!");
                    ViewData["EmailError"] = "*";
                }
            }
                

            if (ModelState.IsValid == true)
            {
                ViewData["Success"] = "<script>alert('Data has been Successsubmitted')</ script >";
                ModelState.Clear();
            }

            return View();
        }
    }
}