using APIClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIClinica.Context
{
    public class Context:DbContext
    {
        public Context()
            : base("ProjectDBContext")
        {

        }

        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Patients> Patients { get; set; }
    }
}