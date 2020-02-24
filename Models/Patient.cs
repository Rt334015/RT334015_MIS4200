using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RT334015_MIS4200.Models
{
    public class Patient
    {
        
        
        public int patientId { get; set; }
        public string fullName { get { return lastName + ", " + firstName; } }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Student First Name is Required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Student Last Name is Required")]
        [StringLength(20)]

        public string lastName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter most frequently used email")]
        public string email { get; set; }

        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage ="Phone Number must be in correct format (xxx) xxx-xxxx or xxx-xxx-xxx")]
        public string phone { get; set; }

        [Display(Name = "When did you join the organization")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode =true)]
        public DateTime patientSince { get; set; }

        [Display(Name = "Visit Details")]
        [StringLength(50)]
        public string details { get; set; }

        [Display(Name = "When were you born?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime dob { get; set; }

        public ICollection<Appointment> Appointment { get; set; }

    }
}