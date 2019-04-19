using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Facade
{
    public class FileUploadViewModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
