using Microsoft.AspNetCore.Mvc;

namespace web7.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Input()
        {
            return View();
        }
        public IActionResult Output()
        {
            return View();
        }
    }
}
