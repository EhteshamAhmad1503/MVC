using CookiesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CookiesDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid == true)
            {
                HttpCookie cookie = new HttpCookie("Username");
                cookie.Value = user.UserName;

                HttpContext.Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}