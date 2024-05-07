using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventiWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly Eventi_pmaContext _dbContext;

        public AdminController(Eventi_pmaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Korisnici()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        public IActionResult Eventi()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            ViewBag.Admin = HttpContext.Session.GetString("Username");
            return View();
        }
        public IActionResult Mjesta()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        public IActionResult Vrste()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        public IActionResult KreirajMjesto()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        [HttpPost]
        public IActionResult KreirajMjesto(string naziv)
        {
            Models.Mjesta mjesto = new Models.Mjesta(null, naziv);
            var dbMjesto = MjestaMapper.ToDatabase(mjesto);
            _dbContext.Mjesta.Add(dbMjesto);
            _dbContext.SaveChanges();
            return RedirectToRoute(new { controller = "Admin", action = "Mjesta" });
        }
        public IActionResult KreirajVrstu()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return View();
        }
        [HttpPost]
        public IActionResult KreirajVrstu(string naziv)
        {
            Models.VrsteEventa vrsta = new Models.VrsteEventa(null, naziv);
            var dbVrsta = VrsteEventaMapper.ToDatabase(vrsta);
            _dbContext.VrsteEventa.Add(dbVrsta);
            _dbContext.SaveChanges();
            return RedirectToRoute(new { controller = "Admin", action = "Vrste" });
        }

    }
}
