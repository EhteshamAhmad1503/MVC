using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplications.Models
{
    public class Details
    {
        
        public int ID { get; set; }
               
        public string FirstName { get; set; }
                
        public string LastName { get; set; }
                
        public string Gender { get; set; }
                
        public int Salary { get; set; }
    }
}