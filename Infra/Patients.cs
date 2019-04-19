using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
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

        public static bool IsValidUser(UserDetails user)
        { return user.UserName == "Admin" && user.Password == "Admin";  }


        public void UploadPatients(List<Patient> patients, RegistryDbContext db)
        {
            db.Patients.AddRange(patients);
            db.SaveChanges();
        }

    }
}
