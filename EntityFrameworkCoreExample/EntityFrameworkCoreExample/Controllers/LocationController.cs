using EntityFrameworkCoreExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreExample.Controllers
{
    public class LocationController : Controller
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
        public IActionResult CreateLocation(Location location)
        {
            using var employeeContext = new EmployeeContext();
            employeeContext.Locations.Add(location);
            employeeContext.SaveChanges(); //don't forget

            return RedirectToAction("Create");
        }
    }
}
