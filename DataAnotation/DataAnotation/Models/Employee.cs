using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnotation.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "Id is Required")]
        public int EmployeeId { get; set; }

        [DisplayName("NAME")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should be greater than 5 less than 20")]
        public string EmployeeName { get; set; }

        [DisplayName("AGE")]
        [Range(20, 60)]
        [Required(ErrorMessage = "Age is Required")]
        public int EmployeeAge { get; set; }

        [DisplayName("GENDER")]
        [Required(ErrorMessage = "Gender is Required")]
        public string EmployeeGender { get; set; }

        [DisplayName("EMAIL")]
        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "Invalid Email")]
        public string EmployeeEmail { get; set; }

        [DisplayName("PASSWORD")]
        [Required(ErrorMessage = "Password is  mandatory")]
        [DataType(DataType.Password)]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format")]
        public string EmployeePassword { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("CONFIRM")]
        [Required(ErrorMessage = "Invalid Password")]
        [Compare("EmployeePassword", ErrorMessage = "Password Not Match")]
        public string ConfirmPassword { get; set; }

        [DisplayName("ORGANIZATION NAME")]
        [ReadOnly(true)]
        public string OranizationName { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("EMP ADDERESS")]
        [Required(ErrorMessage = "Comment Required")]
        public string EmpAdress { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("JOINING DATE")]
        [Required(ErrorMessage = "Joining Date Required")]
        public string EmpJoiningDate { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("JOINING DATE")]
        [Required(ErrorMessage = "Time is Required")]
        public string EmpJoiningTime { get; set; }
    }
}