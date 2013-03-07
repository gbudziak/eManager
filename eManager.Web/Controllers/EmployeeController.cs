using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Web.Models;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = departmentId;
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel) {
            if (ModelState.IsValid) {
                var dept = _db.Departments.Single(d => d.Id == viewModel.DepartmentId);
                var emp = new Employee();
                emp.Name = viewModel.Name;
                emp.HireDate = viewModel.HireDate;
                dept.Employees.Add(emp);
                _db.Save();

                return RedirectToAction("detail", "department", new { id=viewModel.DepartmentId});
            }
            return View(viewModel);
        }

    }
}
