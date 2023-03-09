using StronglyTypedView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student st = new Student();
            st.id = 101;
            st.Name = "Ehtesham";
            st.Age = 25;
            ViewData["Students"] = st;
            return View(st);
        }
    }
}