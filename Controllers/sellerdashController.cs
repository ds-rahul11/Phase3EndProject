﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phase3Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Project.Controllers
{
    public class sellerdashController : Controller
    {
        private readonly Proj3DBContext _context;
        public List<LaptopDetails> laptops { get; set; }
        public int sid { get; set; }
        public sellerdashController(Proj3DBContext context)
        {
            _context = context;
            laptops = _context.LaptopDetails.ToList();
            
        }
        public async Task<IActionResult> Dashboard()
        {
            this.sid = (int)HttpContext.Session.GetInt32("sid");
            ViewBag.user = HttpContext.Session.GetString("sname");
            ViewBag.sid = this.sid;
            return View();
        }
        public async Task<IActionResult> ViewMyLaptops()
        {
            ViewBag.user = HttpContext.Session.GetString("sname");
            ViewBag.sid = (int)HttpContext.Session.GetInt32("sid");
            return View(await _context.LaptopDetails.ToListAsync());
        }
    }
}
