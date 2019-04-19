using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class PatientListViewModel
    {
        public List<PatientViewModel> Patients { get; set; }
        public FooterViewModel FooterData { get; set; }
    }
}
