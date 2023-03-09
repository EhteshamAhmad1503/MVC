using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthorizeFilters.Models
{
    public class LoginController : Controller
    {
        UserDatabaseEntities db = new UserDatabaseEntities();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(User user, string ReturnUrl)
        {
            if (Isvalid(user) == true)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                Session["username"] = user.UserName.ToString();
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View();
            }
        }

        public bool Isvalid(User user)
        {
            var credentials = db.Users.Where(model => model.UserName == user.UserName && model.Password == user.Password).FirstOrDefault();
            if(credentials !=null)
            {
                return (user.UserName == credentials.UserName && user.Password == credentials.Password);
            }
            else
            {
                return false;
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["username"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}