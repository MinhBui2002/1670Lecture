﻿using Microsoft.AspNetCore.Mvc;

namespace web5.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
