using InterviewProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities1 db = new EmployeeDBEntities1();
        public ActionResult Index(string SortOrder, string SortBy)
        {
            ViewBag.SortOrder = SortOrder;
            var data = db.Employees.ToList();

            switch (SortBy)
            {
                case "FirstName":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    data = data.OrderBy(x => x.FirstName).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    data = data.OrderByDescending(x => x.FirstName).ToList();
                                    break;
                                }
                            default:
                                {
                                    data = data.OrderBy(x => x.FirstName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
                case "Gender":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    data = data.OrderBy(x => x.Gender).ToList();
                                    break;
                                }
                            case "Desc":
                                {
                                    data = data.OrderByDescending(x => x.Gender).ToList();
                                    break;
                                }
                            default:
                                {
                                    data = data.OrderBy(x => x.FirstName).ToList();
                                    break;
                                }
                        }
                        break;
                    }
            }

            return View(data);
        }

        [HttpPost]
        public ActionResult Index(string Find, string SortOrder, string SortBy)
        {
            List<Employee> emp = db.Employees.Where(model => model.FirstName.StartsWith(Find)).ToList();
            return PartialView("SearchData", emp);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            var row = db.Employees.Where(model => model.ID == ID).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int ID)
        {
            var row = db.Employees.Where(model => model.ID == ID).FirstOrDefault();
            return View(row);
        }

        public ActionResult Delete(int ID)
        {
            var delete = db.Employees.Where(model => model.ID == ID).FirstOrDefault();
            return View(delete);
        }

        [HttpPost]
        public ActionResult Delete(Employee emp)
        {
            db.Entry(emp).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}