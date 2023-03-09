using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyType_HTMLHelpers.Models
{
    public class SignUp
    {
        public int UserId { get; set; }
        public int UserName { get; set; }
        public int UserPassword { get; set; }
        public int UserGender { get; set; }
        public int UserEmail { get; set; }
        public int UserComments { get; set; }
    }
}