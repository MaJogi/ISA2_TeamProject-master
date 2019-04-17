using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRegistry.Core
{
    public class Patient 
    {
        // Registry has the power to create Patient from the data that they gather
        // from users via requests that they sent via online form
        private const string requiredField = "Required field!";
        private const string lenghtIsToBig = "Length should be less than 20 characters";

        public Patient() { } // Default countroller is needed to create empty Patient

        public Patient(string firstName, string lastName, string idCode, string problem, DateTime? validFrom = null, DateTime? validTo = null)
        {
            FirstName = firstName ?? string.Empty;
            LastName = lastName ?? string.Empty;
            IdCode = idCode;
            Problem = problem;
            ValidFrom = validFrom ?? DateTime.Now; //DateOfPatientCreation //Maybe DateTime.MinValue
            ValidTo = validTo ?? DateTime.MaxValue; //Date when patient is excluded (deleted from system/registry)
        }



        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientId { get; set; }
        [Required(ErrorMessage = requiredField)]
        [StringLength(20, ErrorMessage = lenghtIsToBig)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = requiredField)]
        [StringLength(20, ErrorMessage = lenghtIsToBig)]
        public string LastName { get; set; }
        [Required(ErrorMessage = requiredField)]
        [StringLength(11, MinimumLength = 11, ErrorMessage = lenghtIsToBig)]
        public string IdCode { get; set; }
        public string Problem { get; set; } // will look like a comment on the site
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        //Todo
        //Add phonenumber
    }
}
