using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginForm.Models;


namespace LoginForm.Controllers
{
    public class LoginController : Controller
    {
        UserDBEntities db = new UserDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid == true)
            {
                var Credentials = db.Users.Where(model => model.UserName == user.UserName && model.Password == user.Password).FirstOrDefault();
                if (Credentials == null)
                {
                    ViewBag.ErrorMassage = "Login Failed";
                    return View();
                }
                else
                {
                    Session["username"] = user.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}