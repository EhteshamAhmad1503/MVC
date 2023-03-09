using Microsoft.Extensions.Logging;
using RememeberMeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RememeberMeMVC.Controllers
{
    public class LoginController : Controller
    {
        UserDBEntities db = new UserDBEntities();
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["User"];
            if (cookie != null)
            {
                ViewBag.Username = cookie["Username"].ToString();
                ViewBag.Password = cookie["Password"].ToString();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            HttpCookie cookie = new HttpCookie("User");
            if (ModelState.IsValid == true)
            {
                try
                {
                    if (user.RememberMe == true)
                    {
                        cookie["Username"] = user.UserName;
                        cookie["Password"] = user.Password;
                        cookie.Expires = DateTime.Now.AddDays(2);
                        HttpContext.Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        HttpContext.Response.Cookies.Add(cookie);
                    }

                    var row = db.Users.Where(model => model.UserName == user.UserName && model.Password == user.Password).FirstOrDefault();
                    if (row != null)
                    {
                        Session["Username"] = user.UserName;
                        TempData["Message"] = "Login Successfull !!";
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        TempData["Message"] = "Login Fail !!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong" + ex);
                }

            }
            return View();
        }
    }
}