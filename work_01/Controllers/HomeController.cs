﻿using Microsoft.AspNetCore.Mvc;

namespace work_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
