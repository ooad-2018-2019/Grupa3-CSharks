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
    public class SrednjaSkolaAplikantasController : Controller
    {
        private readonly SaFContext _context;
        private static int idUnos=-1, idEdit = -1;

        public SrednjaSkolaAplikantasController(SaFContext context)
        {
            _context = context;
        }

        // GET: SrednjaSkolaAplikantas
        public async Task<IActionResult> Index()
        {
            var saFContext = _context.SrednjaSkolaAplikanta.Include(s => s.Aplikant).Include(s => s.SrednjaSkola);
            return View(await saFContext.ToListAsync());
        }

        // GET: SrednjaSkolaAplikantas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var srednjaSkolaAplikanta = await _context.SrednjaSkolaAplikanta
                .Include(s => s.Aplikant)
                .Include(s => s.SrednjaSkola)
                .FirstOrDefaultAsync(m => m.SrednjaSkolaAplikantaId == id);
            if (srednjaSkolaAplikanta == null)
            {
                return NotFound();
            }

            return View(srednjaSkolaAplikanta);
        }

        // GET: SrednjaSkolaAplikantas/Create
        public IActionResult Create(int? id)
        {
            //ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator");

            if (id != null)
            {
                idUnos = id.Value;
            }
            ViewData["SrednjaSkolaId"] = new SelectList(_context.SrednjaSkola, "SrednjaSkolaId", "Naziv");
            return View();
        }

        // POST: SrednjaSkolaAplikantas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SrednjaSkolaAplikantaId,SrednjaSkolaId,AplikantId")] SrednjaSkolaAplikanta srednjaSkolaAplikanta)
        {
            if (ModelState.IsValid)
            {
                if (idUnos != -1)
                {
                    srednjaSkolaAplikanta.AplikantId = idUnos;
                    _context.Add(srednjaSkolaAplikanta);
                    await _context.SaveChangesAsync();
                    int idap = idUnos;
                    idUnos = -1;
                    return RedirectToAction("Details", "Aplikant", new { id = idap });
                   

                }
            }
            idUnos = -1;
            ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator", srednjaSkolaAplikanta.AplikantId);
            ViewData["SrednjaSkolaId"] = new SelectList(_context.SrednjaSkola, "SrednjaSkolaId", "SrednjaSkolaId", srednjaSkolaAplikanta.SrednjaSkolaId);
            return View(srednjaSkolaAplikanta);
        }

        // GET: SrednjaSkolaAplikantas/Edit/5
        public async Task<IActionResult> Edit(int? id, int?idApl)
        {
            if (id == null)
            {
                return NotFound();
            }

            var srednjaSkolaAplikanta = await _context.SrednjaSkolaAplikanta.FindAsync(id);
            if (srednjaSkolaAplikanta == null)
            {
                return NotFound();
            }

            if (idApl != null)
            {
                idEdit = idApl.Value;
            }
            ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator", srednjaSkolaAplikanta.AplikantId);
            ViewData["SrednjaSkolaId"] = new SelectList(_context.SrednjaSkola, "SrednjaSkolaId", "SrednjaSkolaId", srednjaSkolaAplikanta.SrednjaSkolaId);
            return View(srednjaSkolaAplikanta);
        }

        // POST: SrednjaSkolaAplikantas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SrednjaSkolaAplikantaId,SrednjaSkolaId,AplikantId")] SrednjaSkolaAplikanta srednjaSkolaAplikanta)
        {
            if (id != srednjaSkolaAplikanta.SrednjaSkolaAplikantaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (idUnos != -1)
                    {
                        int idapl = idUnos;
                        idUnos = -1;
                        _context.Update(srednjaSkolaAplikanta);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Details", "Aplikant", new { id = idapl });
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    idUnos = -1;
                    if (!SrednjaSkolaAplikantaExists(srednjaSkolaAplikanta.SrednjaSkolaAplikantaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                idUnos = -1;
                return RedirectToAction(nameof(Index));
            }
            idUnos = -1;
            ViewData["AplikantId"] = new SelectList(_context.Aplikant, "KorisnikId", "Discriminator", srednjaSkolaAplikanta.AplikantId);
            ViewData["SrednjaSkolaId"] = new SelectList(_context.SrednjaSkola, "SrednjaSkolaId", "SrednjaSkolaId", srednjaSkolaAplikanta.SrednjaSkolaId);
            return View(srednjaSkolaAplikanta);
        }

        // GET: SrednjaSkolaAplikantas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var srednjaSkolaAplikanta = await _context.SrednjaSkolaAplikanta
                .Include(s => s.Aplikant)
                .Include(s => s.SrednjaSkola)
                .FirstOrDefaultAsync(m => m.SrednjaSkolaAplikantaId == id);
            if (srednjaSkolaAplikanta == null)
            {
                return NotFound();
            }

            return View(srednjaSkolaAplikanta);
        }

        // POST: SrednjaSkolaAplikantas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var srednjaSkolaAplikanta = await _context.SrednjaSkolaAplikanta.FindAsync(id);
            _context.SrednjaSkolaAplikanta.Remove(srednjaSkolaAplikanta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SrednjaSkolaAplikantaExists(int id)
        {
            return _context.SrednjaSkolaAplikanta.Any(e => e.SrednjaSkolaAplikantaId == id);
        }
    }
}
