using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        
        StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    TempData["DataInserted"] = "Data Inserted!";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMassage = "Data not Inserted!";
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Student st)
        {
            db.Entry(st).State = EntityState.Modified;
            int b = db.SaveChanges();
            if (b > 0)
            {
                TempData["UpdateData"] = "Data has been Updated!";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Update = "Data not Updated!";
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            var StudentIdRow = db.Students.Where(model => model.ID == ID).FirstOrDefault();
            {
                return View(StudentIdRow);
            }
        }
        [HttpPost]
        public ActionResult Delete(Student s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();

            if (a > 0)
            {
                TempData["DeleteData"] = "Data has been Deleted!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["DeleteData"] = "Data has been not Deleted!";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int ID)
        {
            var Details = db.Students.Where(model => model.ID == ID).FirstOrDefault();
            return View(Details);
        }
    }
}
