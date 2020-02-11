using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RT334015_MIS4200.Models
{
    public class Appointment
    {
        [Key]
        public int appointmentId { get; set; }

        public string description { get; set; }
        public DateTime apptDate { get; set; }

        

        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }

        public int doctorId { get; set; }
        public virtual Doctor Doctor { get; set; }




    }
}