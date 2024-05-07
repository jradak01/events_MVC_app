using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;
using Microsoft.EntityFrameworkCore;

namespace EventiWebApp.Repositories
{
    public class EventiRepository
    {
        private readonly Eventi_pmaContext _dbContext;

        public EventiRepository(Eventi_pmaContext db)
        {
            _dbContext = db;
        }
        public IEnumerable<Models.Eventi> GetAllEventi()
        {
            var db = _dbContext.Eventis;
            var list = _dbContext.Eventis.Select(x => EventiMapper.FromDatabase(x));
            return list;
        }
        public void Save(Models.Eventi event_)
        {
            var dbEvent = EventiMapper.ToDatabase(event_);
            _dbContext.Eventis.Add(dbEvent);
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            while (_dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault() != null)
            {
                var ev = _dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault();
                _dbContext.KorisnikEvents.Remove(ev);
                _dbContext.SaveChanges();
            }
            var event_ = _dbContext.Eventis.Where(x => x.IdEvent == id).FirstOrDefault();
            _dbContext.Eventis.Remove(event_);
            _dbContext.SaveChanges();
        }
        public void Edit(Models.Eventi eventi)
        {
            var dbEvent = EventiMapper.ToDatabase(eventi);
            _dbContext.Eventis.Update(dbEvent);
            _dbContext.SaveChanges();
        }
        public async Task<Models.Eventi> GetAsync(int id)
        {
            var result = await _dbContext.Eventis.SingleOrDefaultAsync(x => x.IdEvent == id);
            return EventiMapper.FromDatabase(result);
        }
        public void EditVezu(Models.KorisnikEvent ke)
        {
            var dbKEvent = KorisnikEventiMapper.ToDatabase(ke);
            _dbContext.KorisnikEvents.Update(dbKEvent);
            _dbContext.SaveChanges();
        }
        public IEnumerable<Models.KorisnikEvent> GetEventiZaOcjenu()
        {
            var db = _dbContext.KorisnikEvents;
            var list = _dbContext.KorisnikEvents.Select(x => KorisnikEventiMapper.FromDatabase(x));
            return list;
        }
        public IEnumerable<Models.Mjesta> GetAllMjesta()
        {
            var db = _dbContext.Mjesta;
            var list = _dbContext.Mjesta.Select(x => MjestaMapper.FromDatabase(x));
            return list;
        }
        public async Task<Models.Mjesta> GetAsyncMjesto(int idMjesto)
        {
            var result = await _dbContext.Mjesta.SingleOrDefaultAsync(x => x.IdMjesto == idMjesto);
            return MjestaMapper.FromDatabase(result);
        }
        public IEnumerable<Models.VrsteEventa> GetAllVrste()
        {
            var db = _dbContext.VrsteEventa;
            var list = _dbContext.VrsteEventa.Select(x => VrsteEventaMapper.FromDatabase(x));
            return list;
        }
        public async Task<Models.VrsteEventa> GetAsyncVrste(int idVrsta)
        {
            var result = await _dbContext.VrsteEventa.SingleOrDefaultAsync(x => x.IdVrsta == idVrsta);
            return VrsteEventaMapper.FromDatabase(result);
        }
         
        public async Task<Models.Korisnici> GetAsyncKorisnik(int id)
        {
            var result = await _dbContext.Korisnicis.SingleOrDefaultAsync(x => x.IdKorisnik == id);
            return KorisniciMapper.FromDatabase(result);
        }

    }
}
