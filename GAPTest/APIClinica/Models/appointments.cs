using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClinica.Models
{
    public class Appointments
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Type { get; set; }

        public virtual Patients Patients { get; set; }
    }
}