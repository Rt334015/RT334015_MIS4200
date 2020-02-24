using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RT334015_MIS4200.Models
{
    public class Doctor
    {
        public int doctorId { get; set; }

        [Display(Name = "Years Experience")]
        [StringLength(50)]

        public string experience { get; set; }
        public string fullName { get { return doctorLastName + ", " + doctorFirstName; } }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Doctor First Name is Required")]
        [StringLength(20)]
        public string doctorFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Doctor Last Name is Required")]
        [StringLength(20)]
        public string doctorLastName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter most frequently used email")]
        public string doctorEmail { get; set; }

        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone Number must be in correct format (xxx) xxx-xxxx or xxx-xxx-xxx")]
        public string doctorPhone { get; set; }
       

        public ICollection<Appointment> Appointment { get; set; }



    }
}