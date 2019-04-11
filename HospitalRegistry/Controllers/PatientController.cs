using System;
using Facade;
using Infra;
using Microsoft.AspNetCore.Mvc;
using HospitalRegistry.Core;
using HospitalRegistry.Infra;

namespace HospitalRegistry.Controllers
{
    public class PatientController : Controller
    {  
        public ActionResult GetView()
        {

            var model = new PatientListViewModel();

            var patients = Patients.Get();

            var list = new List<PatientViewModel>();

            foreach (var p in patients)
            {
                var patient = new PatientViewModel(p);
                list.Add(patient);
            }

            model.Patients = list;
            model.UserName = "Admin";
            
            return View("MyView", model);
        }


        //private readonly HospitalDbContext db;


        //private readonly SalesDbContext db;

        //public EmployeeController(SalesDbContext db) {this.db = db; }

        //[Authorize]
        //public ActionResult Index()
        //{
        //    var model = new EmployeeListViewModel();
        //    model.UserName = User.Identity.Name;
        //    var employees = Employees.Get(db);
        //    var list = new List<EmployeeViewModel>();
        //    foreach (var e in employees)
        //    {
        //        var employee = new EmployeeViewModel(e);
        //        employee.EmployeeId = e.EmployeeId;
        //        list.Add(employee);
        //    }
        //    model.Employees = list;
        //    model.FooterData = new FooterViewModel("TTÜ");
        //    //model.FooterData.CompanyName = "TTÜ";
        //    //model.FooterData.Year = DateTime.Now.Year.ToString();
        //    return View("Index", model);
        //}
        //[Authorize]
        //[AdminFilter]
        //public ActionResult AddNew()
        //{
        //    return View("CreateEmployee", new CreateEmployeeViewModel());
        //}

        //[AdminFilter]
        //[ValidateAntiForgeryToken]
        //public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        //{
        //    if (BtnSubmit != "Save Employee") return RedirectToAction("Index");
        //    if (!ModelState.IsValid) return /*Create(e);*/ View("CreateEmployee", new CreateEmployeeViewModel());
        //    return save(e);

        //}

        //private ActionResult save(Employee e)
        //{
        //    Employees emp = new Employees();
        //    emp.Save(e, db);
        //    return RedirectToAction("Index");
        //}

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null) return NotFound();
        //    Employee employee = db.Employees.Find(id);
        //    if (employee == null) return NotFound();
        //    return View("Delete", employee);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var employee = await db.Employees.SingleOrDefaultAsync
        //        (m => m.EmployeeId == id);
        //    db.Employees.Remove(employee);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null) return NotFound();
        //    var employee = await db.Employees.SingleOrDefaultAsync(m => m.EmployeeId == id);
        //    if (employee == null) return NotFound();
        //    return View("Edit", employee);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id,
        //    [Bind("EmployeeId,FirstName,LastName,Salary")] Employee employee)
        //{
        //    if (id != employee.EmployeeId) return NotFound();
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            db.Update(employee);
        //            await db.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EmployeeExists(employee.EmployeeId)) return NotFound();
        //            throw;
        //        }

        //        return RedirectToAction(nameof(Index));
        //    }

        //    return View(employee);
        //}

        //private bool EmployeeExists(int id)
        //{
        //    return db.Employees.Any(e => e.EmployeeId == id);
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}