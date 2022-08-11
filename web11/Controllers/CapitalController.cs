using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web11.Data;
using web11.Models;

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

        public IActionResult Delete(int? id)
        {
            var capital = context.Capital.Find(id);
            context.Remove(capital);
            context.SaveChanges();
            TempData["Info"] = "Capital is delete?";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Capital capital)
        {
            if (ModelState.IsValid)
            {
                context.Add(capital);
                context.SaveChanges();
                TempData["Info"] = "Add capital successfully!";
                RedirectToAction(nameof(Index));
            }
            return View(capital);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var capital = context.Capital.Find(id);
            return View(capital);
        }

        [HttpPost]
        public IActionResult Edit(Capital capital)
        {
            if (ModelState.IsValid)
            {
                context.Update(capital);
                context.SaveChanges();
                TempData["Info"] = "Update capital successfully!";
                RedirectToAction(nameof(Index));
            }
            return View(capital);
        }


    }
}
