using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CreatePatientViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCode { get; set; }
        public string Problem { get; set; } 
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
