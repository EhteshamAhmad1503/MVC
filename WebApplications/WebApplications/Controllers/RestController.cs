using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplications.Models;
using System.Data.Common;

namespace WebApplications.Controllers
{       
    public class RestController : ApiController
    {   
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployee()
        {
            using (EmployeeDBEntities employee = new EmployeeDBEntities())
            {
                return employee.Employees.ToList();
            }
        }

        [HttpGet]
        public Employee Get(int id )
        {
            using (EmployeeDBEntities employee = new EmployeeDBEntities())
            {
                return employee.Employees.FirstOrDefault(e => e.ID == id);
            }
        }

        [HttpPost]
        public IHttpActionResult PostNewEmployee(Employee student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new EmployeeDBEntities())
            {
                ctx.Employees.Add(new Employee()
                {
                    ID = student.ID,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Gender = student.Gender,
                    Salary = student.Salary
                });

                ctx.SaveChanges();
            }

            return Ok();
        }

       [HttpPut]
        public IHttpActionResult UpdateEmployee(Employee insure)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new EmployeeDBEntities())
            {
                var existingStudent = ctx.Employees.Where(s => s.ID == insure.ID)
                                                        .FirstOrDefault<Employee>();

                if (existingStudent != null)
                {
                    existingStudent.ID = insure.ID;
                    existingStudent.FirstName = insure.FirstName;
                    existingStudent.LastName = insure.LastName;
                    existingStudent.Gender = insure.Gender;
                    existingStudent.Salary = insure.Salary;


                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult RemoveEmployee(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid  id");

            using (var ctx = new EmployeeDBEntities())
            {
                var emp = ctx.Employees
                    .Where(s => s.ID == id)
                    .FirstOrDefault();

                ctx.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

    }
}
