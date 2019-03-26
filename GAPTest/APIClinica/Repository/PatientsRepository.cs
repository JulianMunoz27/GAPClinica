using APIClinica.Interfaces;
using APIClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClinica.Repository
{
    public class PatientsRepository
    {
        private IPatientsInterface _Patients;

        public PatientsRepository(IPatientsInterface patients)
        {
            _Patients = patients;
        }

        public IQueryable<Patients> GetPatients()
        {
            
        }
    }
}