using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSITDemo.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage ="Please Enter Full Name")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        
        [Display(Name = "Full Address")]
        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Full Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;  }

        [Required]
        [Display(Name = "Full Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare ("Password", ErrorMessage = "Password do not Match.")]
        public string ConfirmPassword { get; set; }

    }
}
