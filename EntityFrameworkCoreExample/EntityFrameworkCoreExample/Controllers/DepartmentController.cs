using EntityFrameworkCoreExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreExample.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            using var employeeContext = new EmployeeContext();
            employeeContext.Departments.Add(department);
            employeeContext.SaveChanges(); //don't forget

            return RedirectToAction("Create");
        }

    }
}
