using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeekAndFind.Models;
using SeekAndFind.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace SeekAndFind.Controllers
{
    public class HomeController : Controller
    {


        private SaFContext _context;
        public static Korisnik prijavljenaOsoba = null;
        private static int idAkc=-1;

    public HomeController(SaFContext context)
    {
        _context = context;

    }
    
        public IActionResult Index()
        {
            var viewModel = new TopOglas();

            var oglasi = _context.Oglas;
            foreach(Oglas o in oglasi)
            {
                _context.Entry(o).Collection(p => p.RegistrovaniAplikanti).Load();
                oglasi.Select(p => p.Zanimanje).Load();
            }
            oglasi.ToList().Sort((o1, o2) => o2.RegistrovaniAplikanti.Count.CompareTo(o1.RegistrovaniAplikanti.Count));
            List<Oglas> oglasi2 = new List<Oglas>();
            int brojac = 0;
            foreach(Oglas o in oglasi)
            {
                oglasi2.Add(o);
                brojac++;
                if (brojac == 2) break;
            }
           
            viewModel.Korisnik = prijavljenaOsoba;         
            viewModel.Oglasi = oglasi2;
            return View(viewModel);
        }

        public IActionResult Logout()
        {
            prijavljenaOsoba = null;
            return  RedirectToAction("Index", "Home");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "O Nama";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string sifra, string ponovljenaSifra, IFormCollection fc)
        {
            if (ponovljenaSifra == null || sifra == null || email == null)
            {
                string poruka = "Niste unijeli sva polja!";
                ViewBag.Registracija = poruka;
                return View();
            }

            if (!ponovljenaSifra.Equals(sifra))
            {
                string poruka = "Niste unijeli fino sifru!";
                ViewBag.Registracija = poruka;
                return View();
            }

            var k = _context.Korisnik.Include(o => o.KorisnikId).Where(o => o.Email.Equals(email)); 
            if (k.Count() != 0)
            {
                string poruka = "Već ste registrovani s tom email adresom!";
                ViewBag.Registracija = poruka;
                return View();
            }
            if (ModelState.IsValid)
            {
                if (Convert.ToString(fc["korisnik"]) != null)
                {
                    string radiovalue = Convert.ToString(fc["korisnik"]);
                    if (radiovalue.Equals("poslodavac"))
                    {
                        var p = new Poslodavac { Email = email, Sifra = sifra };
                        _context.Poslodavac.Add(p);
                        _context.SaveChanges();
                        return RedirectToAction("Login");

                    }
                    else if (radiovalue.Equals("aplikant"))
                    {
                        var p = new Aplikant { Email = email, Sifra = sifra };
                        _context.Aplikant.Add(p);
                        _context.SaveChanges();
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            return View();

        }

        public IActionResult Login(int? idOglasa)
        {
            if (idOglasa != null) idAkc = idOglasa.Value;
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string sifra)
        {
            int idOgl = idAkc;
            idAkc = -1;
            if (sifra == null || email == null || sifra.Count() == 0 || email.Count() == 0)
            {
                string poruka = "Niste unijeli sva polja!";
                ViewBag.Log = poruka;
                
                return View();
            }
            var kk = _context.Korisnik.Include(o => o.KorisnikId).Where(o => o.Email.Equals(email) && o.Sifra.Equals(sifra));
            if ( kk.Count() == 0)
            {
                string poruka = "Pogrešni pristupni podaci!";
                ViewBag.Log = poruka;
              
                return View();
            }
            Korisnik k = _context.Korisnik.Where(i => i.Email.Equals(email) && i.Sifra.Equals(sifra)).Single();

            prijavljenaOsoba = k;
            if (idOgl != -1)
            {
                return RedirectToAction("Details", "Oglas", new { id = idOgl });

            }


            if (k is Aplikant)
            {
                return RedirectToAction("Details", "Aplikant", new { id = k.KorisnikId });
            }
            else
            {
                return RedirectToAction("Details", "Poslodavacs", new { id = k.KorisnikId });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
