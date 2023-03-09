using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Submit.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserName { get; internal set; }
    }
}