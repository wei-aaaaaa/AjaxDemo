﻿using Microsoft.AspNetCore.Mvc;

namespace MSIT158Site.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Homework1()
        {
            return View();
        }

        public IActionResult CheckAccount()
        {
            return View();
        }
    }
}
