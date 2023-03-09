using Ahad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ahad.Controllers
{
    public class RishitaController : Controller
    {
        // GET: Rishita
        public ActionResult Md()
        {
            Introduction obj = new Introduction();
           
              obj.id = "1";
            obj.Name = "Ehtesham Ahmad";
              obj.Course = "BCA";
             obj.City = "Hyderabad";
             obj.Collage = "Delhi University";

            ViewBag.obj1 = obj;
                                
            return View();
        }
    }
}