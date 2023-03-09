using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Submit.Models;
using System.Web.Security;

namespace Submit.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Membership model)
        {
            using(var context=new MVCregUserEntities())
            {
                bool isValid = context.User.Any(x => x.UserName == model.Name && x.Password == model.Password);
                if(isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index","Employees");
                }
                ModelState.AddModelError("","Invalid UserName and Password");
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
            using (var context = new MVCregUserEntities())
            {
                context.User.Add(user);
                context.SaveChanges();
            }
            return RedirectToAction("login");
        }
    }
}