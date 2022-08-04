using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web8.Data;
using web8.Models;

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
        public IActionResult Delete(int? id)
        {
            var mobile = context.Mobile.Find(id);
            context.Mobile.Remove(mobile);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                context.Add(mobile);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(mobile);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var mobile = context.Mobile.Find(id);
            return View(mobile);
        }

        [HttpPost]
        public IActionResult Edit(Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                context.Update(mobile);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(mobile);
        }
    }
}
