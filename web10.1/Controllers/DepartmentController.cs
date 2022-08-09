using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web10._1.Data;

namespace web10._1.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext context;

        public DepartmentController(ApplicationDbContext DbContext)
        {
            context = DbContext;
        }
        public IActionResult Index()
        {
            var departments = context.Departments.ToList();
            return View(departments);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var department = context.Departments
                                .Include(d => d.Employees)
                                .FirstOrDefault(d => d.Id == id);
            return View(department);
        }
    }
}
