using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace QuickKartDAL.AllModels.Models
{
    public class LoginDetail
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailId { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The password is required")]
        public string UserPassword { get; set; }
    }
}
