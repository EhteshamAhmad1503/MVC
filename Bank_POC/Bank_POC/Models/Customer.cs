using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bank_POC.Models
{
    public class Customer
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter Your Name")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Enter Valid Email")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Display(Name = "Contect")]
        [Required(ErrorMessage = "Please Enter Valid Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage ="Enter Valid Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }
    }
}