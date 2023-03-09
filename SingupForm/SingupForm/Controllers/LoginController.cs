using SingupForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingupForm.Controllers
{
    public class LoginController : Controller
    {

        UserSignupEntities db = new UserSignupEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User us)
        {
            var data = db.Users.Where(model => model.UserName == us.UserName && model.Password == us.Password).FirstOrDefault();
            if (data != null)
            {
                Session["UserID"] = us.Id.ToString();
                Session["UserName"] = us.UserName.ToString();
                TempData["LoginSuccessMessage"] = "Login Successfully";
                return RedirectToAction("Index", "User");
            }
            else
            {
                ViewBag.ErrorMessage = "Username or Password is incorrect";
                return View();
            }

        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
        {
            db.Users.Add(user);
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.InsertMessage = "Registered Successfully";
                ModelState.Clear();
            }
            else
            {
                ViewBag.InsertMessage = "Try Again...";
            }
            return View();
        }
    }
}