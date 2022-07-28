using Microsoft.AspNetCore.Mvc;
using web6.Models;

namespace web6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult LoginForm()
        {
            return View();
        }

        // check login credentials and show result
        public IActionResult LoginCheck(User user)
        {
            return View(user);
        }
    }

}
