using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookiesDemo.Models
{
    public class User
    {
        [DisplayName("UserName")]
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }
    }
}