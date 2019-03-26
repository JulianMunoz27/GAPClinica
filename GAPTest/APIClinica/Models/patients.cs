using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClinica.Models
{
    public class Patients
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }

        public ICollection<Appointments> Appointments { get; set; }
    }
}