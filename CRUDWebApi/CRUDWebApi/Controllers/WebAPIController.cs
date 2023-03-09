using CRUDWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDWebApi.Controllers
{
    public class WebAPIController : ApiController
    {
        EmployeeDBEntities db = new EmployeeDBEntities();

        [HttpGet]
        public IHttpActionResult Action()
        {
            List<Employee> list = db.Employees.ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetDetailsByid(int id)
        {
            var data = db.Employees.Where(model => model.ID == id).FirstOrDefault();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Insert(Employee emp)
        {
            db.Employees.Add(emp);
            int a = db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult GetEdit(Employee emp)
        {

            db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            //var data = db.Employees.Where(model => model.ID == emp.ID).FirstOrDefault();
            //if (data != null)
            //{
            //    data.ID = emp.ID;
            //    data.FirstName = emp.FirstName;
            //    data.LastName = emp.LastName;
            //    data.Gender = emp.Gender;
            //    data.Salary = emp.Salary;
            //    db.SaveChanges();
            //}
            //else
            //{
            //    return NotFound();
            //}
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult GetDelete(int id)
        {
            var data = db.Employees.Where(model => model.ID == id).FirstOrDefault();
            db.Entry(data).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
