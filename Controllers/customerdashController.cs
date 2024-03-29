﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phase3Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Project.Controllers
{
    public class customerdashController : Controller
    {
        private readonly Proj3DBContext _context;

        public customerdashController(Proj3DBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Checkout(int? id)
        {
            var laptopDetails = await _context.LaptopDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewBag.price = laptopDetails.Price;
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}
