
using demoWeb.Data;
using demoWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demoWeb.Controllers
{
    public class MobileController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public MobileController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        //load toàn bộ dữ liệu của bảng  
        [Authorize]
        public IActionResult Index()
        {
            return View(context.Mobiles.ToList());
        }

        //xoá dữ liệu từ bảng
        public IActionResult Delete(int id)
        {
            var mobile = context.Mobiles.Find(id);
            context.Mobiles.Remove(mobile);
            context.SaveChanges();
            TempData["Message"] = "Delete mobile successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        public IActionResult Detail(int id)
        {
            var mobile = context.Mobiles.Include(m => m.Brand)  //Brand - Mobile : 1 - M
                                     .ThenInclude(b => b.Country)  //Brand - Country : M - 1
                                     .FirstOrDefault(m => m.Id == id);
            return View(mobile);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Brands = context.Brands.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                context.Mobiles.Add(mobile);
                context.SaveChanges();
                TempData["Message"] = "Create mobile successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(mobile);
        }

        //create a http get edit method
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Brands = context.Brands.ToList();
            var mobile = context.Mobiles.Find(id);
            return View(mobile);
        }

        [HttpPost]
        public IActionResult Edit(Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                context.Update(mobile);
                context.SaveChanges();
                TempData["Message"] = "Edit mobile successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(mobile);
        }

        public IActionResult Store()
        {
            return View();
        }
    }
}
