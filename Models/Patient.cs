using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RT334015_MIS4200.Models
{
    public class Patient
    {
        public int patientId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }
        public string details { get; set; }
        public DateTime dob { get; set; }

        public ICollection<Appointment> Appointment { get; set; }

    }
}