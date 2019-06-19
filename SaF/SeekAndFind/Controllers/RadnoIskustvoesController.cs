using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SeekAndFind.Models;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SeekAndFind.Controllers
{
    public class RadnoIskustvoesController : Controller
    {
        private readonly SaFContext _context;
        private static int idApli = -1;
        private static int idAplikantaEdit = -1;

        public RadnoIskustvoesController(SaFContext context)
        {
            _context = context;
        }

        // GET: RadnoIskustvoes
        public async Task<IActionResult> Index()
        {
            var saFContext = _context.RadnoIskustvo.Include(r => r.Zanimanje);
            return View(await saFContext.ToListAsync());
        }

        // GET: RadnoIskustvoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radnoIskustvo = await _context.RadnoIskustvo
                .Include(r => r.Zanimanje)
                .FirstOrDefaultAsync(m => m.RadnoIskustvoId == id);
            if (radnoIskustvo == null)
            {
                return NotFound();
            }

            return View(radnoIskustvo);
        }

        // GET: RadnoIskustvoes/Create
        /* public IActionResult Create()
         {
             ViewData["ZanimanjeId"] = new SelectList(_context.Zanimanje, "ZanimanjeId", "ZanimanjeId");
             return View();
         }*/

        public IActionResult Create(int? id)
        {

            ViewData["ZanimanjeId"] = new SelectList(_context.Zanimanje, "ZanimanjeId", "Naziv");
            if (id != null) idApli = id.Value;
            return View();
        }


        // POST: RadnoIskustvoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RadnoIskustvoId,ZanimanjeId,Kompanija,DatumPocetka,DatumKraja")] RadnoIskustvo radnoIskustvo)
        {
            if (ModelState.IsValid)
            {

                _context.Add(radnoIskustvo);
                await _context.SaveChangesAsync();
                if (idApli != -1)
                {

                    Console.WriteLine("Tu sam");
                    RadnoIskustvoAplikanta radnoIskApl = new RadnoIskustvoAplikanta();
                    radnoIskApl.AplikantId = idApli;
                    radnoIskApl.RadnoIskustvoId = radnoIskustvo.RadnoIskustvoId;

                    _context.Add(radnoIskApl);
                    await _context.SaveChangesAsync();
                    int idA = idApli;
                    idApli = -1;
                    return RedirectToAction("Details", "Aplikant", new { id = idA });

                }
                idApli = -1;
                return RedirectToAction(nameof(Index));
            }
            idApli = -1;
            ViewData["ZanimanjeId"] = new SelectList(_context.Zanimanje, "ZanimanjeId", "ZanimanjeId", radnoIskustvo.ZanimanjeId);



            return View(radnoIskustvo);
        }

        // GET: RadnoIskustvoes/Edit/5
        public async Task<IActionResult> Edit(int? id, int? idAplikanta)
        {
            if (id == null)
            {
                return NotFound();
            }

            string apiUrl = "https://seekandfindapi.azurewebsites.net/";

            RadnoIskustvo radnoIskustvo = new RadnoIskustvo();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/RadnoIskustvoes/" + id);
                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    radnoIskustvo = JsonConvert.DeserializeObject<RadnoIskustvo>(response);
                }
            }

            //var radnoIskustvo = await _context.RadnoIskustvo.FindAsync(id);
            if (radnoIskustvo == null)
            {

                return NotFound();
            }

            if (idAplikanta != null)
            {
                idAplikantaEdit = idAplikanta.Value;

            }
            ViewData["ZanimanjeId"] = new SelectList(_context.Zanimanje, "ZanimanjeId", "Naziv", radnoIskustvo.ZanimanjeId);
            return View(radnoIskustvo);
        }

        // POST: RadnoIskustvoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RadnoIskustvoId,ZanimanjeId,Kompanija,DatumPocetka,DatumKraja")] RadnoIskustvo radnoIskustvo)
        {
            if (id != radnoIskustvo.RadnoIskustvoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radnoIskustvo);
                    await _context.SaveChangesAsync();

                    if (idAplikantaEdit != -1)
                    {
                        int id2 = idAplikantaEdit;
                        idAplikantaEdit = -1;
                        return RedirectToAction("Details", "Aplikant", new { id = id2 });

                    }


                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadnoIskustvoExists(radnoIskustvo.RadnoIskustvoId))
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
            ViewData["ZanimanjeId"] = new SelectList(_context.Zanimanje, "ZanimanjeId", "ZanimanjeId", radnoIskustvo.ZanimanjeId);
            return View(radnoIskustvo);
        }

        // GET: RadnoIskustvoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radnoIskustvo = await _context.RadnoIskustvo
                .Include(r => r.Zanimanje)
                .FirstOrDefaultAsync(m => m.RadnoIskustvoId == id);
            if (radnoIskustvo == null)
            {
                return NotFound();
            }

            return View(radnoIskustvo);
        }

        // POST: RadnoIskustvoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var radnoIskustvo = await _context.RadnoIskustvo.FindAsync(id);
            _context.RadnoIskustvo.Remove(radnoIskustvo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadnoIskustvoExists(int id)
        {
            return _context.RadnoIskustvo.Any(e => e.RadnoIskustvoId == id);
        }
    }
}
