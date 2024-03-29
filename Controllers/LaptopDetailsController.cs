﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Phase3Project.Model;

namespace Phase3Project.Controllers
{
    public class LaptopDetailsController : Controller
    {
        private readonly Proj3DBContext _context;

        public LaptopDetailsController(Proj3DBContext context)
        {
            _context = context;
        }

        // GET: LaptopDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.LaptopDetails.ToListAsync());
        }
        public async Task<IActionResult> viewProducts()
        {
            return View(await _context.LaptopDetails.ToListAsync());
        }

        // GET: LaptopDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptopDetails = await _context.LaptopDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laptopDetails == null)
            {
                return NotFound();
            }

            return View(laptopDetails);
        }

        // GET: LaptopDetails/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModelName,Processor,Ram,Storage,GraphicsCard,Price,SId")] LaptopDetails laptopDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laptopDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laptopDetails);
        }

        // GET: LaptopDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptopDetails = await _context.LaptopDetails.FindAsync(id);
            if (laptopDetails == null)
            {
                return NotFound();
            }
            return View(laptopDetails);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModelName,Processor,Ram,Storage,GraphicsCard,Price,SId")] LaptopDetails laptopDetails)
        {
            if (id != laptopDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laptopDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaptopDetailsExists(laptopDetails.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(laptopDetails);
        }

        // GET: LaptopDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptopDetails = await _context.LaptopDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laptopDetails == null)
            {
                return NotFound();
            }

            return View(laptopDetails);
        }

        // POST: LaptopDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laptopDetails = await _context.LaptopDetails.FindAsync(id);
            _context.LaptopDetails.Remove(laptopDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaptopDetailsExists(int id)
        {
            return _context.LaptopDetails.Any(e => e.Id == id);
        }
    }
}
