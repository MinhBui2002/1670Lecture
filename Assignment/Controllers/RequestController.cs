using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View(context.Requests.ToList());
        }


       
        [HttpGet]
        public IActionResult MakeRequest()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult MakeRequest(Request request)
        {
            if (ModelState.IsValid)
            {
                request.Status = false;
                context.Add(request);
                context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            return View(request);
        }

        //delete the request
        public IActionResult Delete(int id)
        {
            var request = context.Requests.Find(id);
            context.Requests.Remove(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //display all requests
        public IActionResult DisplayRequests()
        {
            return View(context.Requests.ToList());
        }
    }
}
