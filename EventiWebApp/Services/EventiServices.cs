using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.Models;
using EventiWebApp.Repositories;

namespace EventiWebApp.Services
{
    public class EventiServices
    {
        public EventiRepository _eventiRepository;
        
        public EventiServices(EventiRepository eventiRepostiory)
        {
            _eventiRepository = eventiRepostiory;
        }

        public IEnumerable<Eventi> GetAllEventi()
        {
            return _eventiRepository.GetAllEventi();
        }
        public IEnumerable<KorisnikEvent> GetEventiZaOcjenu()
        {
            return _eventiRepository.GetEventiZaOcjenu();
        }
        public void Save(Eventi event_)
        {
            _eventiRepository.Save(event_);
        }
       
        public void Delete (int id)
        {
            _eventiRepository.Delete(id);
        }
        public void Edit(Eventi event_)
        {
            _eventiRepository.Edit(event_);
        }
        public void EditVezu(KorisnikEvent ke)
        {
            _eventiRepository.EditVezu(ke);
        }
        public async Task<Eventi> GetAsync(int id)
        {
            return await _eventiRepository.GetAsync(id);
        }
        public IEnumerable<Mjesta> GetAllMjesta()
        {
            return _eventiRepository.GetAllMjesta();
        }
        public async Task<Mjesta> GetAsyncMjesto(int id)
        {
            return await _eventiRepository.GetAsyncMjesto(id);
        }
        public IEnumerable<VrsteEventa> GetAllVrste()
        {
            return _eventiRepository.GetAllVrste();
        }
        public async Task<VrsteEventa> GetAsyncVrste(int id)
        {
            return await _eventiRepository.GetAsyncVrste(id);
        }
        public async Task<Korisnici> GetAsyncKorisnik(int id)
        {
            return await _eventiRepository.GetAsyncKorisnik(id);
        }

    }
}

