using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcStores.Models
{
    public class PhoneBookModel
    {
        [Required]
        [Display(Name="First Name")]
        [StringLength(50, ErrorMessage="This {0} must be at least {2} characters", MinimumLength=6)]
        public string FirstName { get; set; }

        [Display(Name = "Midlle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Mobile")]
        public string MobileNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name="Email")]
        public string Email { get; set; }

    }
}