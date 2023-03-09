using Ehtesham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ehtesham1.Controllers
{
    public class EhteshamController : Controller
    {
        // GET: Ehtesham/
        public ActionResult Ehtesham()
        {
            Student obj = new Student();

            obj.ID = "201";
            obj.Name = "Ehtesham Ahmad ";
            obj.Department = "IT";

            ViewBag.std = obj;
            return View(obj);
        }
    }
}