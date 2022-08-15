﻿using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Assignment.Controllers
{
    public class BookController : Controller
    {
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        
        public IActionResult Index()
        {
            return View(context.Books.ToList());
        }

        
        public IActionResult Delete(int id)
        {
            var book = context.Books.Find(id);
            context.Books.Remove(book);
            context.SaveChanges();
            TempData["Message"] = "Delete book successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        public IActionResult Detail(int id)
        {
            var book = context.Books
                .Include(c => c.Author)
                .Include(c => c.Category)
                .FirstOrDefault(c => c.Id == id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Authors = context.Authors.ToList();
            ViewBag.Categories = context.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                TempData["Message"] = "Add new book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        //create a http get edit method
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Authors = context.Authors.ToList();
            ViewBag.Categories = context.Categories.ToList();
            var book = context.Books.Find(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Update(book);
                context.SaveChanges();
                TempData["Message"] = "Edit book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public IActionResult Store()
        {
            return View(context.Books.ToList());
        }
    }
}
