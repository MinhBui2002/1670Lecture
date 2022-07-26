using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web5.Models;

namespace web5.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Demo/Greenwich.cshtml");
        }

        public IActionResult Demo1()
        {
            string City = "London";
            int Population = 8_000_000;
            bool isChecked = true;
            double Temperature = 1.8;
            ViewData["City"] = City;
            ViewData["Population"] = Population;
            ViewData["isChecked"] = isChecked;
            ViewData["Temperature"] = Temperature;


            return View();
        }

        public IActionResult Demo2()
        {
            List<string> Cities = new List<string>()
            {
                "London",
                "Paris",
                "New York",
                "Tokyo",
                "Beijing",
                "Moscow",
                "Seoul",
            };
            return View();
        }

        public IActionResult Demo3()
        {
            //create a list of mobiles
            List<Mobile> mobiles = new List<Mobile>();
            mobiles.Add(new Mobile(1, "Samsung", 32, 324.3));
            mobiles.Add(new Mobile(2, "Apple", 32, 324.3));
            mobiles.Add(new Mobile(3, "OnePlus", 32, 324.3));
            


            return View(mobiles);
        }

    }
}
