using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["username"] == null)
            {
                TempData["LoginMessage"] = "<script>  alert('Login successfully')</script>";
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}