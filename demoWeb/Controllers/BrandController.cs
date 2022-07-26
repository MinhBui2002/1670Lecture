﻿using demoWeb.Data;
using demoWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demoWeb.Controllers
{
    public class BrandController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public BrandController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        //load toàn bộ dữ liệu của bảng  
        [Authorize]
        public IActionResult Index()
        {
            return View(context.Brands.ToList());
        }

        //xoá dữ liệu từ bảng
        public IActionResult Delete(int id)
        {
            var brand = context.Brands.Find(id);
            context.Brands.Remove(brand);
            context.SaveChanges();
            TempData["Message"] = "Delete brand successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        public IActionResult Detail(int id)
        {
            var brand = context.Brands.Include(b => b.Mobiles)  //Brand - Mobile : 1 - M
                                     .Include(b => b.Country)  //Brand - Country : M - 1
                                     .FirstOrDefault(b => b.Id == id);
            return View(brand);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = context.Countries.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                context.Brands.Add(brand);
                context.SaveChanges();
                TempData["Message"] = "Create brand successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }

        //create a http get edit method
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Countries = context.Countries.ToList();
            var brand = context.Brands.Find(id);
            return View(brand);
        }

        [HttpPost]
        public IActionResult Edit(Brand brand)
        {
            if (ModelState.IsValid)
            {
                context.Update(brand);
                context.SaveChanges();
                TempData["Message"] = "Edit brand successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }
    }
}
