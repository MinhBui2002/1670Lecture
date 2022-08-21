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
            order.Status = "Pending";
            order.BookId = id;
            order.OrderQuantity = quantity;
            order.OrderPrice = book.Price * quantity;
            order.OrderDate = DateTime.Now;
            order.UserEmail = User.Identity.Name;
            
            context.Order.Add(order);
           
            book.Quantity -= quantity;
            context.Books.Update(book);
            
            context.SaveChanges();
            
            TempData["Success"] = "Order book successfully !";
            
            return RedirectToAction("Store", "Book");
        }

        
        public IActionResult Delete(int id)
        {
            var order = context.Order.Find(id);
            var book = context.Books.Find(order.BookId);
            book.Quantity += order.OrderQuantity;
            context.Order.Remove(order);
            context.SaveChanges();
            
            return RedirectToAction("Index", "Order");
        }

        public IActionResult Accept(int id)
        {
            var order = context.Order.Find(id);
            order.Status = "Accept";
            context.SaveChanges();
            return RedirectToAction("Index", "Order");
        }

        public IActionResult Reject(int id)
        {
            var order = context.Order.Find(id);
            var book = context.Books.Find(order.BookId);
            book.Quantity += order.OrderQuantity;
            order.Status = "Reject";
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
