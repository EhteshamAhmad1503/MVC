using Image.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Image.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();

        public ActionResult Index()
        {
            var data = db.Information.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Information student)
        {
            string fileName = Path.GetFileNameWithoutExtension(student.ImageFile.FileName);
            string Extention = Path.GetExtension(student.ImageFile.FileName);
            HttpPostedFileBase PostedFile = student.ImageFile;
            int length = PostedFile.ContentLength;

            if (Extention.ToLower() == ".jpg" || Extention.ToLower() == ".png" || Extention.ToLower() == ".jpeg")
            {
                if (length <= 1000000)
                {
                    fileName = Extention + fileName;
                    student.Image = "~/Images/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                    student.ImageFile.SaveAs(fileName);
                    db.Information.Add(student);
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        ViewBag.Message = "Data has been inserted successfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Data Not Inserted";

                    }
                }
                else
                {
                    ViewBag.SizeMessage = "Size should be in range";
                }
            }
            else
            {
                ViewBag.ExtentionMessage = "Image not supported";
            }

            return View();
        }
    }
}