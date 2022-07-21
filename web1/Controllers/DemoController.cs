using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
        
    }
}
