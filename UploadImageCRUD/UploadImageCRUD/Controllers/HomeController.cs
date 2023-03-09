using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadImageCRUD.Models;

namespace UploadImageCRUD.Controllers
{
    public class HomeController : Controller
    {
        StudentDBEntities studentDB = new StudentDBEntities();

        public ActionResult Index(Student student)
        {
            var data = studentDB.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            var fileName = Path.GetFileNameWithoutExtension(student.ImageFile.FileName);
            var Extention = Path.GetExtension(student.ImageFile.FileName);
            HttpPostedFileBase FileBase = student.ImageFile;
            var length = FileBase.ContentLength;
            if (Extention.ToLower() == ".jpg" || Extention.ToLower() == ".png" || Extention.ToLower() == ".jpeg")
            {
                if (length <= 1000000)
                {
                    fileName = fileName + Extention;
                    student.ImagePath = "~/Image/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                    student.ImageFile.SaveAs(fileName);
                    studentDB.Students.Add(student);
                    int a = studentDB.SaveChanges();
                    if (a > 0)
                    {
                        TempData["Message"] = "<script>  alert('Data has been inserted successfully')</script>";
                        ModelState.Clear();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Message"] = "<script>alert('Data has been  not inserted')</script>";
                    }
                }
                else
                {
                    TempData["SizeMessage"] = "<script>alert('Image should be in range')</script>";
                }
            }
            else
            {
                TempData["ExtentionMessage"] = "<script>alert('Image not supported')</script>";
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var EmployeeRow = studentDB.Students.Where(model => model.StudentId == id).FirstOrDefault();
            Session["Image"] = EmployeeRow.ImagePath;
            return View(EmployeeRow);
        }

        [HttpPost]
        public ActionResult Edit(Student st)
        {
            if (ModelState.IsValid == true)
            {
                if (st.ImageFile != null)
                {
                    var fileName = Path.GetFileNameWithoutExtension(st.ImageFile.FileName);
                    var Extention = Path.GetExtension(st.ImageFile.FileName);
                    HttpPostedFileBase FileBase = st.ImageFile;
                    var length = FileBase.ContentLength;
                    if (Extention.ToLower() == ".jpg" || Extention.ToLower() == ".png" || Extention.ToLower() == ".jpeg")
                    {
                        if (length <= 1000000)
                        {
                            fileName = fileName + Extention;
                            st.ImagePath = "~/Image/" + fileName;
                            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                            st.ImageFile.SaveAs(fileName);
                            studentDB.Entry(st).State = EntityState.Modified;
                            int a = studentDB.SaveChanges();
                            if (a > 0)
                            {
                                string ImagePath = Request.MapPath(Session["Image"].ToString());
                                if (System.IO.File.Exists(ImagePath))
                                {
                                    System.IO.File.Delete(ImagePath);
                                }
                                TempData["UpdateMessage"] = "<script>  alert('Data has been Edited successfully')</script>";
                                ModelState.Clear();
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                TempData["UpdateMessage"] = "<script>alert('Data has been  not Edited')</script>";
                            }
                        }
                        else
                        {
                            ViewBag.SizeMessage = "<script>alert('Image should be in range')</script>";
                        }
                    }
                    else
                    {
                        TempData["ExtentionMessage"] = "<script>alert('Image not supported')</script>";
                    }
                }
                else
                {
                    st.ImagePath = Session["Image"].ToString();
                    studentDB.Entry(st).State = EntityState.Modified;
                    int a = studentDB.SaveChanges();
                    if (a > 0)
                    {
                        TempData["UpdateMessage"] = "<script>alert('Data has been Edited successfully')</script>";
                        ModelState.Clear();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["UpdateMessage"] = "<script>alert('Data has been  not Edited')</script>";
                    }
                }

            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var data = studentDB.Students.Where(model => model.StudentId == id).FirstOrDefault();

                if (data != null)
                {
                    studentDB.Entry(data).State = EntityState.Deleted;
                    int a = studentDB.SaveChanges();
                    if (a > 0)
                    {
                        TempData["DeleteMessage"] = "<script>  alert('Data has been Deleted successfully')</script>";
                        string ImagePath = Request.MapPath(data.ImagePath.ToString());
                        if (System.IO.File.Exists(ImagePath))
                        {
                            System.IO.File.Delete(ImagePath);
                        }
                    }
                    else
                    {
                        TempData["DeleteMessage"] = "<script>  alert('Data has been not deleted successfully')</script>";
                    }
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Details(int id)
        {
            var Details = studentDB.Students.Where(model => model.StudentId == id).FirstOrDefault();
            Session["Image2"] = Details.ImagePath.ToString(); 
            return View(Details);
        }
    }
}