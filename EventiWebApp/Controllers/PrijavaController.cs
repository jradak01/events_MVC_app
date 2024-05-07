using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventiWebApp.Services;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace EventiWebApp.Controllers
{
    public class PrijavaController : Controller
    {
        private readonly PrijavaService _prijavaServices;

        public PrijavaController(PrijavaService prijavaService)
        {
            _prijavaServices = prijavaService;
        }

        public IActionResult Prijava()
        {
            if (HttpContext.Session.GetString("Admin") == "False")
                return RedirectToRoute(new { controller = "Korisnik", action = "Eventi" });
            else if (HttpContext.Session.GetString("Admin") == "True")
                return RedirectToRoute(new { controller = "Admin", action = "Eventi" });
            return View();
        }
        [HttpPost]
        public IActionResult Prijava(string korisnickoIme, string lozinka)
        {
            if (HttpContext.Session.GetString("Admin") == "False")
                return RedirectToRoute(new { controller = "Korisnik", action = "Eventi" });
            else if (HttpContext.Session.GetString("Admin") == "True")
                return RedirectToRoute(new { controller = "Admin", action = "Eventi" });
            var korisnik = _prijavaServices.PrijavaKorisnik(korisnickoIme, lozinka);
            if (korisnik != null)
            {
                HttpContext.Session.SetString("Id", korisnik.IdKorisnik.ToString());
                HttpContext.Session.SetString("Username", korisnik.KorisnickoIme);
                HttpContext.Session.SetString("Admin", korisnik.Admin.ToString());
                var uloga = HttpContext.Session.GetString("Admin");
                if (uloga == "True")
                {
                    return RedirectToRoute(new { controller = "Admin", action = "Eventi" });
                }
                else
                {
                    return RedirectToRoute(new { controller = "Korisnik", action = "Eventi" });
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Registracija()
        {
            if (HttpContext.Session.GetString("Admin") == "False")
                return RedirectToRoute(new { controller = "Korisnik", action = "Eventi" });
            else if (HttpContext.Session.GetString("Admin") == "True")
                return RedirectToRoute(new { controller = "Admin", action = "Eventi" });
            return View();
        }

        [HttpPost]
        public IActionResult Registracija(string ime, string prezime, string korisnickoIme, string loz, string loz2, string email)
        {
            if (HttpContext.Session.GetString("Admin") == "False")
                return RedirectToRoute(new { controller = "Korisnik", action = "Eventi" });
            else if (HttpContext.Session.GetString("Admin") == "True")
                return RedirectToRoute(new { controller = "Admin", action = "Eventi" });
            var noviKorisnik = _prijavaServices.VerificirajKorisnika(ime, prezime, korisnickoIme, loz, loz2, email);
            if (noviKorisnik == null)
            {
                return View();
            }
            else
            {
                int Id = _prijavaServices.RegistrirajKorisnika(noviKorisnik);
                HttpContext.Session.SetString("IdKorisnik", Id.ToString());
                HttpContext.Session.SetString("KorisnickoIme", noviKorisnik.KorisnickoIme);
                HttpContext.Session.SetString("Admin", noviKorisnik.Admin.ToString());
                return RedirectToRoute(new { controller = "Korisnik", action = "Eventi" });
            }
        }

        public IActionResult Odjava()
        {
            HttpContext.Session.Clear();
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
