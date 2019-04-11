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
        public PatientViewModel(Patient patient, string userName)
        {
            setName(patient);
            setProblem(patient);
            setProblemColor(patient);
            setUserName(userName);

        }

        public string PatientName { get; set; }
        public string IdCode { get; set; }
        public string Problem { get; set; }
        public string ProblemColor { get; private set; } = "red";
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string UserName { get; set; }

        internal void setName(Patient p)
        {
            PatientName = p.FirstName + " " + p.LastName;
        }

        internal void setProblemColor(Patient p)
        {
            if (!ReferenceEquals(null, p))
            {
                ProblemColor = p.Problem == "Head" ? "crimson" : "indigo";
                
            }
            else
            {
                ProblemColor = "red";
            }
        }

        internal void setProblem(Patient p)
        {
            Problem = p.Problem;
        }

        internal void setUserName(string userName)
        {
            UserName = userName ?? string.Empty;
        }
    }
}
