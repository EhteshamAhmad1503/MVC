using SignUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SignUp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(Models.User model)
        {
            using(var context=new MVCregUserEntities1())
            {
                bool isValid = context.Users.Any(x => x.UserName == model.UserName && x.Password ==model.Password);
                if(isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName,false);
                    return RedirectToAction("Index", "Employee");
                }
                ModelState.AddModelError("","Invalid UserName And Password");
                return View();
            }
         }

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User model)
        {
            using (var context=new MVCregUserEntities())
            {
                context.User.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("LogIn");
        }
    }
}