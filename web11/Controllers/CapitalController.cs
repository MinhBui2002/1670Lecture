using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web11.Data;

namespace web11.Controllers
{
    public class CapitalController : Controller
    {
        private ApplicationDbContext context;
        public CapitalController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Capital
                .Include(c => c.Country)
                .ToList());
        }

        public IActionResult Detail(int? id)
        {
            var capital = context.Capital
                .Include(c => c.Country)
                .FirstOrDefault(c => c.Id == id);
            if (capital == null)
            {
                return NotFound();
            }
            return View(capital);
        }
    }
}
