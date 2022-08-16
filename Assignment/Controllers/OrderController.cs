using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace Assignment.Controllers
{
    public class OrderController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public OrderController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        [Authorize(Roles = "Customer")]
        [HttpPost]
        public IActionResult Make(int id, int quantity)
        {
            
            var order = new Order();
            
            var book = context.Books.Find(id);
            order.Book = book;
            order.BookId = id;
            order.OrderQuantity = quantity;
            order.OrderPrice = book.Price * quantity;
            order.OrderDate = DateTime.Now;
            order.UserEmail = User.Identity.Name;
            //add Order vào DB
            context.Order.Add(order);
            //trừ quantity của book
            book.Quantity -= quantity;
            context.Books.Update(book);
            //lưu cập nhật vào DB
            context.SaveChanges();
            //gửi về thông báo order thành công
            TempData["Success"] = "Order book successfully !";
            //redirect về trang book store
            return RedirectToAction("Store", "Book");
        }

        [Authorize(Roles = "Customer,Admin")]
        public IActionResult Delete(int id)
        {
            var order = context.Order.Find(id);
            context.Order.Remove(order);
            context.SaveChanges();
            return RedirectToAction("Index", "Order");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var orders = context.Order
                .Include(c => c.Book)
                .ToList();
            return View(orders);
        }
        // renders orders of the current user
        [Authorize(Roles = "Customer")]
        public IActionResult IndexForCurrent()
        {
            var orders = context.Order
                .Include(c => c.Book)
                .Where(c => c.UserEmail == User.Identity.Name)
                .ToList();
            return View(orders);
        }






    }
}
