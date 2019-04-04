using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRegistry.Models
{
    public class Department
    {
        public Department() { }

        public Department(string name) //Maybe add the functionality to add array of doctors at one in department List Doctors etc.
        {
            Name = name;
        }


        public string ID { get; set; } //make auto generated
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; } //Maybe make it collection?
    }
}
