﻿using Microsoft.AspNetCore.Mvc;

namespace LMS.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
