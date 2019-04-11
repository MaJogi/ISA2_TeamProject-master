using System;
using HospitalRegistry.Core;
using System.Collections.Generic;

namespace Infra
{
    public class Patients
    {
        public static List<Patient> Get()
        {
            var patients = new List<Patient>
            {
                new Patient("John", "Doe", "39805225211", "Nina", DateTime.Parse("12/12/2012"), DateTime.Parse("12/12/2021")),
                new Patient("Michael", "Jackson", "39805225211", "Kõrv"),
                new Patient("Robert", "Pattinson", "39805225211", "Varvas")
            };
            return patients;
        }
    }
}
