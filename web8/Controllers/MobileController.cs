using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web8.Data;

namespace web8.Controllers
{
    public class MobileController : Controller
    {
        protected readonly ApplicationDbContext context;

        public MobileController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var mobiles = context.Mobile.ToList();
            return View(mobiles);
        }

        public IActionResult List()
        {
            return View(context.Mobile.ToList());
        }
        public IActionResult Detail(int? id)
        {
            var mobile = context.Mobile.FirstOrDefault(m => m.Id == id);
            return View(mobile);
        }
    }
}
