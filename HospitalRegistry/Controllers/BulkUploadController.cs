using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Facade;
using HospitalRegistry.Core;
using Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalRegistry.Controllers
{
    public class BulkUploadController : Controller
    {
        private readonly RegistryDbContext db;

        public BulkUploadController(RegistryDbContext database)
        {
            db = database;
        }
        //[AdminFilter]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }

        //[AdminFilter]
        public ActionResult Upload(IFormFile fileUpload)
        {
            List<Patient> patients = GetPatients(fileUpload);
            Patients p = new Patients();
            p.UploadPatients(patients, db);
            return RedirectToAction("Index", "Patient");
        }



        private List<Patient> GetPatients(IFormFile file)
        {
            List<Patient> patients = new List<Patient>();
            StreamReader csvreader = new StreamReader(file.OpenReadStream());
            csvreader.ReadLine();
            while (!csvreader.EndOfStream)
            {
                var line = csvreader.ReadLine();
                var values = line.Split(',');
                Patient p = new Patient();
                p.FirstName = values[0];
                p.LastName = values[1];
                p.IdCode = values[2];
                p.Problem = values[3];
                p.ValidFrom = Convert.ToDateTime(values[4]);
                p.ValidTo = Convert.ToDateTime(values[5]);
                patients.Add(p);
            }
            return patients;

        }
    }

    
}