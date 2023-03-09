using DataBaseFirstApproachs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataBaseFirstApproachs.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid == true)
            {
                db.Employees.Add(employee);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertData"] = "Data has been Inserted";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InsertData"] = "Data not Inserted";
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            var row = db.Employees.Where(model => model.ID == ID).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(employee).State = EntityState.Modified;
                int update = db.SaveChanges();
                if (update > 0)
                {
                    TempData["updateMassage"] = " Data has been updated";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["updateMassage"] = "Data not updated";
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            var delete = db.Employees.Where(model => model.ID == ID).FirstOrDefault();
            return View(delete);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(employee).State = EntityState.Deleted;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["DeleteMassage"] = " Data has been Deleted";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["DeleteMassage"] = "Data not Deleted";
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Details(int ID)
        {
            var Details = db.Employees.Where(model => model.ID == ID).FirstOrDefault();
            return View(Details);
        }
    }
}