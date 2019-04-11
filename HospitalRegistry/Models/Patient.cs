using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRegistry.Models
{
    public class Patient // Registry has the power to create Patient from the data that they gather
        // from users via requests that they sent via online form
        //
    {
        public Patient() { } // Default countroller is needed to create empty Patient

        public Patient(string name, string idCode, string problem, DateTime? validFrom = null, DateTime? validTo = null)
        { 

        Name = name;
        IdCode = idCode;
        Problem = problem;
        ValidFrom = validFrom ?? DateTime.Now; //DateOfPatientCreation //Maybe DateTime.MinValue
        ValidTo = validTo ?? DateTime.MaxValue; //Date when patient is excluded (deleted from system/registry)
        }
    //Make it database generated
    //[DatabaseGenerated()]
    public string ID { get; set; }
    public string Name { get; set; }
    public string IdCode { get; set; }
    public string Problem { get; set; } // will look like a comment on the site
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; } 


}
}
