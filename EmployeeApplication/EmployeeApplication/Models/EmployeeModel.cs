using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeApplication.Models
{
    public class EmployeeModel
    {   [Key]
        [Display(Name ="Employee Id")]
        [Range(1,1000 , ErrorMessage ="Please Enter Valid Employee Id")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Enter Your First Name")]
        public string FirstName { get; set; }

        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter Your Last Name")]
        public string LastName { get; set; }

        [Display(Name= "EmailAddress")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter Your Email Address")]
        public string EmailAddress { get; set; } 

        [Display(Name = "Confirm Email")]
        [DataType(DataType.EmailAddress)]
        [Compare("EmailAddress",ErrorMessage ="The Email and Confirmed must Match")]
        public string ConfirmEmail { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage ="You must have a password")]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength =10,ErrorMessage ="You need to provide a long enough password")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Your Password and Confirm Password is do not Match")]
        public string ConfirmPassword { get; set; }
    }
}