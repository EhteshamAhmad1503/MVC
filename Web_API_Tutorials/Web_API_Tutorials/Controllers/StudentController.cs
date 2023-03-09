using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Tutorials.Controllers
{
    public class StudentController : ApiController
    {
        public string[] Name = { "Ehtesham", "Gulam", "irfan" };

        [HttpGet]
        public string[] GetStudent()
        {
            return Name;
        }

        [HttpGet]
        public string GetStudents(int id)
        {
            return Name[id];
        }
    }
}
