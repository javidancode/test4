﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
