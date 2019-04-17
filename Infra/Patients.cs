using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HospitalRegistry.Core;

namespace Infra
{
    public class Patients
    {
        public static List<Patient> Get(RegistryDbContext db)
        {
            return db.Patients.ToList();
        }
        public Patient Save(Patient p, RegistryDbContext db)
        {
            db.Patients.Add(p);
            db.SaveChanges();
            return p;
        }
    }
}
