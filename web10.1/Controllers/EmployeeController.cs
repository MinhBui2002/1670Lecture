using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web10._1.Data;

namespace web10._1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }


        //view all staffs
        public IActionResult Index()
        {
            var staffs = context.Employees
                .Include(s => s.Department)
                .ToList();  //array of Staff objects
            return View(staffs); //gửi dữ liệu sang view bằng model
        }

        //view staff by id
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var staff = context.Employees
                                .Include(s => s.Department)
                                .FirstOrDefault(s => s.Id == id);
            //Staff object
            return View(staff);
        }
    }
}
