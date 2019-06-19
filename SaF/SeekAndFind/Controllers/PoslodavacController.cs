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
    public class PoslodavacController : Controller
    {
        private readonly SaFContext _context;

        public PoslodavacController(SaFContext context)
        {
            _context = context;
        }

        // GET: Poslodavac
        public async Task<IActionResult> Index()
        {
            return View(await _context.Poslodavac.ToListAsync());
        }

        // GET: Poslodavac/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poslodavac = await _context.Poslodavac
                .FirstOrDefaultAsync(m => m.KorisnikId == id);
            if (poslodavac == null)
            {
                return NotFound();
            }

            return View(poslodavac);
        }

        // GET: Poslodavac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Poslodavac/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PoslodavacId,Naziv,OPoslodavcu,Detalji,KorisnikId,Telefon,Email,Grad,Sifra")] Poslodavac poslodavac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poslodavac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poslodavac);
        }

        // GET: Poslodavac/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poslodavac = await _context.Poslodavac.FindAsync(id);
            if (poslodavac == null)
            {
                return NotFound();
            }
            return View(poslodavac);
        }

        // POST: Poslodavac/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PoslodavacId,Naziv,OPoslodavcu,Detalji,KorisnikId,Telefon,Email,Grad,Sifra")] Poslodavac poslodavac)
        {
            if (id != poslodavac.KorisnikId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poslodavac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PoslodavacExists(poslodavac.KorisnikId))
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
            return View(poslodavac);
        }

        // GET: Poslodavac/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poslodavac = await _context.Poslodavac
                .FirstOrDefaultAsync(m => m.KorisnikId == id);
            if (poslodavac == null)
            {
                return NotFound();
            }

            return View(poslodavac);
        }

        // POST: Poslodavac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poslodavac = await _context.Poslodavac.FindAsync(id);
            _context.Poslodavac.Remove(poslodavac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PoslodavacExists(int id)
        {
            return _context.Poslodavac.Any(e => e.KorisnikId == id);
        }
    }
}
