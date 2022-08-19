using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace Assignment.Controllers
{
    
    public class RequestController : Controller
    {
        private ApplicationDbContext context;
        public RequestController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        [Authorize(Roles = "Admin, StoreOwner")]
        public IActionResult Index()
        {
            return View(context.Requests.ToList());
        }


        [Authorize(Roles = "StoreOwner")]
        [HttpGet]
        public IActionResult MakeRequest()
        {

            return View();
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpPost]
        public IActionResult MakeRequest(Request request)
        {
            if (ModelState.IsValid)
            {
                request.Status = "Pending";
                context.Add(request);
                context.SaveChanges();
                TempData["Message"] = "Make request success";
                return RedirectToAction("Index");
            }
            return View();
        }

        //delete the request
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var request = context.Requests.Find(id);
            request.Status = "Rejected";
            context.Update(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Accept(int id)
        {
            var request = context.Requests.Find(id);
            request.Status = "Accepted";
            context.Update(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //display all requests
        [Authorize(Roles = "Admin")]
        public IActionResult DisplayRequests()
        {
            return View(context.Requests.ToList());
        }
        [HttpPost]
        [Authorize(Roles = "Admin, StoreOwner")]
        public IActionResult Search(string status)
        {
            var requests = context.Requests.Where(m => m.Status.Contains(status)).ToList();
            return View("Index", requests);
        }
    }
}
