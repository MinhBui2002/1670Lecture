using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Assignment.Controllers
{
    [Authorize(Roles = "StoreOwner")]
    public class AuthorController : Controller
    {
        private ApplicationDbContext context;
        public AuthorController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View(context.Authors.ToList());
        }

        public IActionResult Delete(int id)
        {
            var author = context.Authors.Find(id);
            context.Authors.Remove(author);
            context.SaveChanges();
            TempData["Message"] = "Delete author successfully !";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int id)
        {
            var author = context.Authors.Include(c => c.Book)
                                             .FirstOrDefault(c => c.Id == id);
            return View(author);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                context.Authors.Add(author);
                context.SaveChanges();
                TempData["Message"] = "Create author successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = context.Authors.Find(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            if (ModelState.IsValid)
            {
                context.Authors.Update(author);
                context.SaveChanges();
                TempData["Message"] = "Edit author successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

    }
}

