using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Models
{
    public class Staff
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage ="Email is not valid")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Department")]
        public Departments? Department { get; set; }

        [Required]
        [Display(Name = "Photo")]
        public string PhotoFilePath { get; set; }
    }
}
