using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Views
{
    public class Klienci : Controller
    {
        private readonly WebApplication7Context _context;

        public Klienci(WebApplication7Context context)
        {
            _context = context;
        }

        // GET: Klienci
        public async Task<IActionResult> Index()
        {
            return View(await _context.Klientcs.ToListAsync());
        }

        // GET: Klienci/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klientcs = await _context.Klientcs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (klientcs == null)
            {
                return NotFound();
            }

            return View(klientcs);
        }

        // GET: Klienci/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Klienci/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Imie,Nazwisko,Znizka")] Klient klientcs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(klientcs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(klientcs);
        }

        // GET: Klienci/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klientcs = await _context.Klientcs.FindAsync(id);
            if (klientcs == null)
            {
                return NotFound();
            }
            return View(klientcs);
        }

        // POST: Klienci/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Imie,Nazwisko,Znizka")] Klient klientcs)
        {
            if (id != klientcs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(klientcs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KlientcsExists(klientcs.Id))
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
            return View(klientcs);
        }

        // GET: Klienci/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klientcs = await _context.Klientcs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (klientcs == null)
            {
                return NotFound();
            }

            return View(klientcs);
        }

        // POST: Klienci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var klientcs = await _context.Klientcs.FindAsync(id);
            _context.Klientcs.Remove(klientcs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KlientcsExists(int id)
        {
            return _context.Klientcs.Any(e => e.Id == id);
        }
    }
}
