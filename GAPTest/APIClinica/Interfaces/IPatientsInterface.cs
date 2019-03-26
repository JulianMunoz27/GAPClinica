using APIClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClinica.Interfaces
{
    public interface IPatientsInterface
    {
        Patients GetPatients();
    }
}