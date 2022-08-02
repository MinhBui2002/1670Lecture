using Microsoft.AspNetCore.Mvc;
using web7.Models;

namespace web7.Controllers
{
    public class EmployeeController : Controller

    {
        [Route("/")]
        public IActionResult Input()
        {
            return View("~/Views/Employee/Form.cshtml");
        }
        public IActionResult Output(Employee employee)
        {
            return View(employee);
        }
    }
}
