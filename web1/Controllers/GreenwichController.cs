using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace web1.Controllers
{
    public class GreenwichController : Controller
    {
        public IActionResult Index()
        {
            string name = "University of Greenwich";
            string address = "Cau Giay - Hanoi";
            //current year
            int year = 2009;

            ViewData["name"] = name;
            ViewData["address"] = address;
            ViewData["year"] = year;
            
            float grade = 10;
            ViewBag.Grade = grade;
            List<string> students = new List<string>
            {
                "Jake","Mike","Obama","John"
            };
            ViewBag.Student = students;
            return View();
        }
    }
}
