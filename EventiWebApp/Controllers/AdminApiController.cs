using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EventiWebApp.Models;
using EventiWebApp.Services;
using Newtonsoft.Json.Linq;
using EventiWebApp.DtoMappers;

namespace EventiWebApp.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        private AdminServices _adminServices;
        public AdminApiController(AdminServices adminServices)
        {
            _adminServices = adminServices;
        }
        //api/admin/svieventi
        //dohvacanje svih eventa
        [HttpGet("svieventi")]
        public ActionResult<List<Eventi>> Get()
        {
            Console.WriteLine("Api");
            return _adminServices.GetAllEventi().ToList();
        }
        //api/admin/brsanjeeventa/id
        //brisanje odredenog eventa
        [HttpDelete("brisanjeeventa/{id}")]
        public void Delete(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return;
            _adminServices.Delete(id);
        }
        //api/admin/event/id
        //dohvacanje jednog eventa pomocu ID
        [HttpGet("event/{id}")]
        public async Task<ActionResult<Eventi>> GetOne(int id)
        {
            return await _adminServices.GetAsync(id);
        }
        //api/admin/svikorisnici
        //dohvacanje svih korisnika
        [HttpGet("svikorisnici")]
        public ActionResult<List<Korisnici>> GetKorisnik()
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            Console.WriteLine("Api");
            return _adminServices.GetAllKorisnici().ToList();
        }
        //api/adminbrisanjekorisnika/id
        //brisanje odredenog korisnika
        [HttpDelete("brisanjekorisnika/{id}")]
        public void DeleteKorisnik(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return;
            _adminServices.DeleteKorisnik(id);

        }
        //api/admin/korisnik/id
        //dohvacanje jednog korisnika pomocu ID
        [HttpGet("korisnik/{id}")]
        public async Task<ActionResult<Korisnici>> GetOneKorisnik(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return await _adminServices.GetAsyncKorisnik(id);
        }
        //api/admin/korisnikedit
        //uređivanje korisnika
        [HttpPut("korisnikedit")]
        public void EditKorisnik([FromBody] JObject json)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return;
            var korisnik = KorisnikDto.FromJson(json);

            _adminServices.Edit(korisnik);
        }
        //api/admin/svamjesta
        //dohvacanje svih mjesta
        [HttpGet("svamjesta")]
        public ActionResult<List<Mjesta>> GetMjesta()
        {
            return _adminServices.GetAllMjesta().ToList();
        }
        //api/admin/addmjesto
        //dodavanje mjesta
        [HttpPost("addmjesto")]
        public ActionResult SaveMjesto([FromBody] JObject json)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            var mjesto = MjestaDto.FromJson(json);
            _adminServices.Save(mjesto);
            return Ok();
        }
        //api/admin/mjestoedit
        //uređivanje mjesta
        [HttpPut("mjestoedit")]
        public void Edit([FromBody] JObject json)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return;
            var mjesto = MjestaDto.FromJson(json);

            _adminServices.Edit(mjesto);
        }
        //api/admin/mjesto/id
        //dohvacanje jednog mjesta
        [HttpGet("mjesto/{id}")]
        public async Task<ActionResult<Mjesta>> GetOneMjesto(int id)
        {
            return await _adminServices.GetAsyncMjesto(id);
        }
        //api/admin/brisanjemjesta/id
        //brisanje jednog mjesta
        [HttpDelete("brisanjemjesta/{id}")]
        public void DeleteMjesta(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return;
            _adminServices.DeleteMjesta(id);

        }
        //api/admin/svevrste
        //dohvacanje svih vrsta
        [HttpGet("svevrste")]
        public ActionResult<List<VrsteEventa>> GetVrste()
        {
            return _adminServices.GetAllVrste().ToList();
        }
        //api/admin/addvrstu
        //dodavanje vrste
        [HttpPost("addvrstu")]
        public ActionResult SaveVrstu([FromBody] JObject json)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            var vrsta = VrsteEventaDto.FromJson(json);
            _adminServices.Save(vrsta);
            return Ok();
        }
        //api/admin/vrstaedit
        //uređivanje vrste
        [HttpPut("vrstaedit")]
        public void EditVrstu([FromBody] JObject json)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return;
            var vrsta= VrsteEventaDto.FromJson(json);
            _adminServices.Edit(vrsta);
        }
        //api/admin/vrsta/id
        //dohvacanje jedne vrste
        [HttpGet("vrsta/{id}")]
        public async Task<ActionResult<VrsteEventa>> GetOneVrsta(int id)
        {
            return await _adminServices.GetAsyncVrste(id);
        }
        //api/admin/brisanjevrste/id
        //brisanje jedne vrste
        [HttpDelete("brisanjevrste/{id}")]
        public void DeleteVrstu(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "True")
                return;
            _adminServices.DeleteVrste(id);

        }
    }
}
