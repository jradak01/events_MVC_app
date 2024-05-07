using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EventiWebApp.Controllers
{
    public class KorisnikController : Controller
    {
        private readonly Eventi_pmaContext _dbContext;

        public KorisnikController(Eventi_pmaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Eventi()
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            ViewBag.Korisnik = HttpContext.Session.GetString("Username");
            return View();
        }
        public IActionResult MojiEventi()
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        public IActionResult EventiZaOcjenu()
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        public IActionResult DopustiNaMojEvent()
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        public IActionResult KreirajEvent()
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        public IActionResult UspjesnoKreiranEvent()
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        [HttpPost]
        public IActionResult KreirajEvent(string naziv, DateTime vrijeme, int mjesto, string adresa, string cijena, int vrstaEventa, string ograniceniPosjetitelji)
        {
            bool ograniceni;
            if (ograniceniPosjetitelji == "0")
            {
                ograniceni = false;
            }
            else
            {
                ograniceni = true;
            }
            string id = HttpContext.Session.GetString("Id");
            Models.Eventi event_ = new Models.Eventi(null, naziv, vrijeme, mjesto, adresa, cijena, vrstaEventa, int.Parse(id), ograniceni);
            var dbEvent = EventiMapper.ToDatabase(event_);
            _dbContext.Eventis.Add(dbEvent);
            _dbContext.SaveChanges();
            return RedirectToRoute(new { controller = "Korisnik", action = "UspjesnoKreiranEvent" });
        }
        [HttpPost]
        public IActionResult PrijaviEvent(string idEvent)
        {
            string id = HttpContext.Session.GetString("Id");
            Models.KorisnikEvent korisnikEvent = new Models.KorisnikEvent(null, int.Parse(idEvent), int.Parse(id), false, null);
            var dbKorisnikEvent = KorisnikEventiMapper.ToDatabase(korisnikEvent);
            _dbContext.KorisnikEvents.Add(dbKorisnikEvent);
            _dbContext.SaveChanges();
            return RedirectToRoute(new { controller = "Korisnik", action = "Eventi" });
        }
        
    }
}
