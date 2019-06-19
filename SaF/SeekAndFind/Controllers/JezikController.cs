using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeekAndFind.Models;

namespace SeekAndFind.Controllers
{
    public class JezikController : Controller
    {
        private readonly SaFContext _context;

        public JezikController(SaFContext context)
        {
            _context = context;
        }

        // GET: Jezik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jezik.ToListAsync());
        }

        // GET: Jezik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jezik = await _context.Jezik
                .FirstOrDefaultAsync(m => m.JezikId == id);
            if (jezik == null)
            {
                return NotFound();
            }

            return View(jezik);
        }

        // GET: Jezik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jezik/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JezikId,Naziv")] Jezik jezik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jezik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jezik);
        }

        // GET: Jezik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jezik = await _context.Jezik.FindAsync(id);
            if (jezik == null)
            {
                return NotFound();
            }
            return View(jezik);
        }

        // POST: Jezik/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JezikId,Naziv")] Jezik jezik)
        {
            if (id != jezik.JezikId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jezik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JezikExists(jezik.JezikId))
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
            return View(jezik);
        }

        // GET: Jezik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jezik = await _context.Jezik
                .FirstOrDefaultAsync(m => m.JezikId == id);
            if (jezik == null)
            {
                return NotFound();
            }

            return View(jezik);
        }

        // POST: Jezik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jezik = await _context.Jezik.FindAsync(id);
            _context.Jezik.Remove(jezik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JezikExists(int id)
        {
            return _context.Jezik.Any(e => e.JezikId == id);
        }
    }
}
