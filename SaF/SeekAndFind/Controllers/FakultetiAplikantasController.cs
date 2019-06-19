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
    public class FakultetiAplikantasController : Controller
    {
        private readonly SaFContext _context;
        private static int idUnos = -1;

        public FakultetiAplikantasController(SaFContext context)
        {
            _context = context;
        }

        // GET: FakultetiAplikantas
        public async Task<IActionResult> Index()
        {
            var saFContext = _context.FakultetiAplikanta.Include(f => f.Aplikant).Include(f => f.Fakultet);
            return View(await saFContext.ToListAsync());
        }

        // GET: FakultetiAplikantas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fakultetiAplikanta = await _context.FakultetiAplikanta
                .Include(f => f.Aplikant)
                .Include(f => f.Fakultet)
                .FirstOrDefaultAsync(m => m.FakultetiAplikantaId == id);
            if (fakultetiAplikanta == null)
            {
                return NotFound();
            }

            return View(fakultetiAplikanta);
        }

        // GET: FakultetiAplikantas/Create
        public IActionResult Create(int? id)
        {
            if (id != null)
            {
                idUnos = id.Value;
            }
            ViewData["FakultetId"] = new SelectList(_context.Fakultet, "FakultetId", "Naziv");
            return View();
        }

        // POST: FakultetiAplikantas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FakultetiAplikantaId,FakultetId,AplikantId")] FakultetiAplikanta fakultetiAplikanta)
        {
            if (ModelState.IsValid)
            {

                if (idUnos != -1)
                {
                    fakultetiAplikanta.AplikantId = idUnos;
                    _context.Add(fakultetiAplikanta);
                    await _context.SaveChangesAsync();
                    int idap = idUnos;
                    idUnos = -1;
                    return RedirectToAction("Details", "Aplikant", new { id = idap });
                }
               idUnos = -1;         
            }
            idUnos = -1;
            ViewData["FakultetId"] = new SelectList(_context.Fakultet, "FakultetId", "FakultetId", fakultetiAplikanta.FakultetId);
            return View(fakultetiAplikanta);
        }

        // GET: FakultetiAplikantas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fakultetiAplikanta = await _context.FakultetiAplikanta.FindAsync(id);
            if (fakultetiAplikanta == null)
            {
                return NotFound();
            }
            ViewData["FakultetId"] = new SelectList(_context.Fakultet, "FakultetId", "FakultetId", fakultetiAplikanta.FakultetId);
            return View(fakultetiAplikanta);
        }

        // POST: FakultetiAplikantas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FakultetiAplikantaId,FakultetId,AplikantId")] FakultetiAplikanta fakultetiAplikanta)
        {
            if (id != fakultetiAplikanta.FakultetiAplikantaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fakultetiAplikanta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FakultetiAplikantaExists(fakultetiAplikanta.FakultetiAplikantaId))
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
            ViewData["FakultetId"] = new SelectList(_context.Fakultet, "FakultetId", "FakultetId", fakultetiAplikanta.FakultetId);
            return View(fakultetiAplikanta);
        }

        // GET: FakultetiAplikantas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fakultetiAplikanta = await _context.FakultetiAplikanta
                .Include(f => f.Aplikant)
                .Include(f => f.Fakultet)
                .FirstOrDefaultAsync(m => m.FakultetiAplikantaId == id);
            if (fakultetiAplikanta == null)
            {
                return NotFound();
            }

            return View(fakultetiAplikanta);
        }

        // POST: FakultetiAplikantas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fakultetiAplikanta = await _context.FakultetiAplikanta.FindAsync(id);
            _context.FakultetiAplikanta.Remove(fakultetiAplikanta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FakultetiAplikantaExists(int id)
        {
            return _context.FakultetiAplikanta.Any(e => e.FakultetiAplikantaId == id);
        }
    }
}
