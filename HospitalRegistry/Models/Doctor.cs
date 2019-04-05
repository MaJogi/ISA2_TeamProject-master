using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace HospitalRegistry.Models
{
    public class Doctor
    {
        public Doctor() { }

        public Doctor(string name, string cabinet, string email, string phone, string aadress)
        {
            Name = name;
            Cabinet = cabinet;
            Email = email;  
            Phone = phone;  
            Aadress = aadress;
        }
        //[DatabaseGenerated()] make ID databasegenerated
        public string ID { get; set; }
        public string Name { get; set; }
        public string Cabinet { get; set; } //Like teachers main office
        public string Email { get; set; }
        public string Aadress { get; set; }
        public string Phone { get; set; }
        // public List<Patient> myPatientList {get; set;}
        
    }
}
