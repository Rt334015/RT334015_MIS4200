using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RT334015_MIS4200.Models
{
    public class Doctor
    {
        public int doctorId { get; set; }

        public string experience { get; set; }
        public string doctorFirstName { get; set; }
        public string doctorLastName { get; set; }
        public string doctorEmail { get; set; }
        public string doctorPhone { get; set; }
       

        public ICollection<Appointment> Appointment { get; set; }



    }
}