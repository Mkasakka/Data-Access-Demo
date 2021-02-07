using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace DataAccessDemo.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employ ID")]
        [Range(100000,999999, ErrorMessage = "The ID needs to be 6 digits and not start with zero")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Give us your name!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Give us your name!")]
        public string LastName { get; set;  }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email adress")]
        [Required(ErrorMessage = "Give us your Email!")]
        public string EmailAddress { get; set; }

        [Compare("EmailAddress", ErrorMessage = "Adreses do not match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Give us a password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Comfirm password")]
        [Compare("Password", ErrorMessage = "Passwords need to match")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }

    }
}