﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Project.Controllers
{
    public class mainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
