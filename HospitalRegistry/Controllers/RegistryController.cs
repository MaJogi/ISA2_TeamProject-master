using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalRegistry.Controllers
{
    public class RegistryController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return Content("Hello form Registry Controller");
        }
    }
}