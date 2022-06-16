using EntityFrameworkCoreExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreExample.Controllers
{
    public class EmployeeController : Controller
    {
        //public IActionResult Index()
        //{
        //    using var context = new EmployeeContext();
        //    var employee = (from e in context.Employees
        //                    join l in context.Locations
        //                    on DepartmentRefId equals l.Id
        //                    select new
        //                    {
        //                        Id = e.Id,
        //                        Name = e.Name,
        //                        LocationName = l.Name
        //                    }
        //    ).ToList();
        //    return View(employee);

        //}

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            using var employeeContext = new EmployeeContext();
            employeeContext.Employees.Add(employee);
            employeeContext.SaveChanges(); //don't forget

            return RedirectToAction("Create");
        }
    }
}
