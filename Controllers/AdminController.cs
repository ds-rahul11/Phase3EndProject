using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase3Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {   
            ViewBag.user = HttpContext.Session.GetString("aname");
            ViewBag.s = HttpContext.Session.GetInt32("s_count");
            ViewBag.c = HttpContext.Session.GetInt32("c_count");
            ViewBag.l = HttpContext.Session.GetInt32("l_count");
            return View();
        }
    }
}
