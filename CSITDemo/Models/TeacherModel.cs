using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSITDemo.Models
{
    public class TeacherModel
    {
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Display(Name = "Full Subject")]
        public string Subject { get; set; }
        [Display(Name = "Full Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Full Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
