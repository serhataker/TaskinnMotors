﻿using Microsoft.AspNetCore.Mvc;

namespace Server
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
