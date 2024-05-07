using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EventiWebApp.Services;
using EventiWebApp.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using EventiWebApp.DtoMappers;

namespace EventiWebApp.Controllers
{
    [Route("api/korisnik")]
    [ApiController]
    public class KorisnikApiController : ControllerBase
    {
        private EventiServices _eventiServices;
        public KorisnikApiController(EventiServices eventiServices)
        {
            _eventiServices = eventiServices;
        }
        //dohvacanje svih eventa default
        [HttpGet]
        public ActionResult<List<Eventi>> Get()
        {
            
            return _eventiServices.GetAllEventi().ToList();
        }
        //dodavanje eventa
        [HttpPost("addevent")]
        public ActionResult Save([FromBody] JObject json)
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            var event_ = EventiDto.FromJson(json);
            _eventiServices.Save(event_);
            return Ok();
        }
        
        //brisanje eventa
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return;
            _eventiServices.Delete(id);

        }
        //ažuriranje eventa
        [HttpPut("eventedit")]
        public void Edit([FromBody] JObject json)
        {
            //if (HttpContext.Session.GetString("Admin") != "False")
            //    return;
            var event_ = EventiDto.FromJson(json);

            _eventiServices.Edit(event_);
        }
        //dohvacanje jednog eventa
        [HttpGet("{id}")]
        public async Task<ActionResult<Eventi>> GetOne(int id)
        {
            return await _eventiServices.GetAsync(id);
        }

        //uređivanje korisnikEvent
        [HttpPut("editvezu")]
        public void EditVezu([FromBody] JObject json)
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return;
            var ke = KorisnikEventDto.FromJson(json);
            _eventiServices.EditVezu(ke);
        }
        [HttpGet("eventizaocjenu")]
        public ActionResult<List<KorisnikEvent>> GetEventiZaOcjenu()
        {
            if (HttpContext.Session.GetString("Admin") != "False")
                return RedirectToRoute(new { controller = "Prijava", action = "Prijava" });
            return _eventiServices.GetEventiZaOcjenu().ToList();
        }

        //dohvacanje svih mjesta
        [HttpGet("svamjesta")]
        public ActionResult<List<Mjesta>> GetMjesta()
        {
            return _eventiServices.GetAllMjesta().ToList();
        }
        //dohvacanje jednog mjesta
        [HttpGet("mjesto/{id}")]
        public async Task<ActionResult<Mjesta>> GetOneMjesto(int id)
        {
            return await _eventiServices.GetAsyncMjesto(id);
        }

        //dohvacanje svih vrsta eventa
        [HttpGet("svevrste")]
        public ActionResult<List<VrsteEventa>> GetVrste()
        {
            return _eventiServices.GetAllVrste().ToList();
        }
        //dohvacanje jedne vrste eventa
        [HttpGet("vrsta/{id}")]
        public async Task<ActionResult<VrsteEventa>> GetOneVrsta(int id)
        {
            return await _eventiServices.GetAsyncVrste(id);
        }

        //dohvacanje jednog korisnika po Id-u 
        [HttpGet("korisnik/{id}")]
        public async Task<ActionResult<Korisnici>> GetOneKorisnik(int id)
        {
            return await _eventiServices.GetAsyncKorisnik(id);
        }
    }
}
