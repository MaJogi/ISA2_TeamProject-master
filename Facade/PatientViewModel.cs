using HospitalRegistry.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class PatientViewModel
    {
        public PatientViewModel(Patient patient)
        {
            if (patient is null) return;
            setName(patient);
            setProblem(patient);
            setProblemColor(patient);
            setIdCode(patient);
            setValidFrom(patient);
            setValidTo(patient);

        }

        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string IdCode { get; set; }
        public string Problem { get; set; }
        public string ProblemColor { get; private set; } = "red";
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        internal void setName(Patient p) //make it internal and fix not working with tests issue
        {
            PatientName = p.FirstName + " " + p.LastName;
        }

        internal void setProblemColor(Patient p)
        {
            if (!ReferenceEquals(null, p)) // if patient isn't null
            {
                ProblemColor = p.Problem == "Head" ? "Yellow" : "Magenta";
                
            }
            else
            {
                ProblemColor = "Red";
            }
        }

        internal void setProblem(Patient p)
        {
            Problem = p.Problem;
        }

        internal void setIdCode(Patient p)
        {
            IdCode = p.IdCode;
        }

        internal void setValidFrom(Patient p)
        {
            ValidFrom = p.ValidFrom;
        }
        internal void setValidTo(Patient p)
        {
            ValidTo = p.ValidTo;
        }
    }
}
