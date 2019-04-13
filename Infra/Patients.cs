using System;
using System.Collections.Generic;
using System.Text;
using HospitalRegistry.Core;

namespace Infra
{
    public static class Patients
    {
        public static List<Patient> Get()
        {
            var patients = new List<Patient>
            {
                new Patient("John", "Doe", "39805225211", "Nina", DateTime.Parse("12/12/2012"), DateTime.Parse("12/12/2021")),
                new Patient("Michael", "Jackson", "39805225211", "Kõrv"),
                new Patient("Robert", "Pattinson", "39805225211", "Varvas"),
                new Patient("Marko", "Jõgi", "39805225211", "Head")
            };
            return patients;
        }
    }
}
