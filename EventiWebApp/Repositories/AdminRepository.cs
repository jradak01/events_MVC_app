using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventiWebApp.DbModels;
using EventiWebApp.Mappers;
using Microsoft.EntityFrameworkCore;

namespace EventiWebApp.Repositories
{
    public class AdminRepository
    {
        private readonly Eventi_pmaContext _dbContext;

        public AdminRepository(Eventi_pmaContext db)
        {
            _dbContext = db;
        }

        public IEnumerable<Models.Eventi> GetAllEventi()
        {
            var db = _dbContext.Eventis;
            var list = _dbContext.Eventis.Select(x => EventiMapper.FromDatabase(x));
            return list;
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
        public async Task<Models.Eventi> GetAsync(int id)
        {
            var result = await _dbContext.Eventis.SingleOrDefaultAsync(x => x.IdEvent == id);
            return EventiMapper.FromDatabase(result);
        }
 
        public IEnumerable<Models.Mjesta> GetAllMjesta()
        {
            var db = _dbContext.Mjesta;
            var list = _dbContext.Mjesta.Select(x => MjestaMapper.FromDatabase(x));
            return list;
        }
        public void Save(Models.Mjesta mjesto)
        {
            var dbMjesta = MjestaMapper.ToDatabase(mjesto);
            _dbContext.Mjesta.Add(dbMjesta);
            _dbContext.SaveChanges();
        }
        public void Edit(Models.Mjesta mjesto)
        {
            var dbCourse = MjestaMapper.ToDatabase(mjesto);
            _dbContext.Mjesta.Update(dbCourse);
            _dbContext.SaveChanges();
        }
        public async Task<Models.Mjesta> GetAsyncMjesto(int idMjesto)
        {
            var result = await _dbContext.Mjesta.SingleOrDefaultAsync(x => x.IdMjesto == idMjesto);
            return MjestaMapper.FromDatabase(result);
        }
        public void DeleteMjesto(int id) 
        {
            while (_dbContext.Eventis.Where(x => x.Mjesto.Equals(id)).FirstOrDefault() != null)
            {
                var ev = _dbContext.Eventis.Where(x => x.Mjesto.Equals(id)).FirstOrDefault();
                DeleteVezu(ev.IdEvent);
                _dbContext.Eventis.Remove(ev);
                _dbContext.SaveChanges();
            }
            var mjesto = _dbContext.Mjesta.Where(x => x.IdMjesto == id).FirstOrDefault();
            _dbContext.Mjesta.Remove(mjesto);
            _dbContext.SaveChanges();
        }
        public void DeleteVezu(int id)
        {
            while (_dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault() != null)
            {
                var kor = _dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault();
                _dbContext.KorisnikEvents.Remove(kor);
                _dbContext.SaveChanges();
            }
        }
        public IEnumerable<Models.VrsteEventa> GetAllVrste()
        {
            var db = _dbContext.VrsteEventa;
            var list = _dbContext.VrsteEventa.Select(x => VrsteEventaMapper.FromDatabase(x));
            return list;
        }
        public void Save(Models.VrsteEventa vrsta)
        {

            var dbVrste = VrsteEventaMapper.ToDatabase(vrsta);
            _dbContext.VrsteEventa.Add(dbVrste);
            _dbContext.SaveChanges();
        }
        
        public void Edit(Models.VrsteEventa vrsta)
        {
            var dbCourse = VrsteEventaMapper.ToDatabase(vrsta);
            _dbContext.VrsteEventa.Update(dbCourse);
            _dbContext.SaveChanges();
        }
        public async Task<Models.VrsteEventa> GetAsyncVrste(int idVrsta)
        {
            var result = await _dbContext.VrsteEventa.SingleOrDefaultAsync(x => x.IdVrsta == idVrsta);
            return VrsteEventaMapper.FromDatabase(result);
        }
        public void DeleteVrstu(int id)
        {
            while (_dbContext.Eventis.Where(x => x.VrstaEventa.Equals(id)).FirstOrDefault() != null)
            {
                var ev = _dbContext.Eventis.Where(x => x.VrstaEventa.Equals(id)).FirstOrDefault();
                DeleteVezu(ev.IdEvent);
                _dbContext.Eventis.Remove(ev);
                _dbContext.SaveChanges();
            }
            var vrsta = _dbContext.VrsteEventa.Where(x => x.IdVrsta == id).FirstOrDefault();
            _dbContext.VrsteEventa.Remove(vrsta);
            _dbContext.SaveChanges();
        }
        public IEnumerable<Models.Korisnici> GetAllKorisnici()
        {
            var db = _dbContext.Korisnicis;
            var list = _dbContext.Korisnicis.Select(x => KorisniciMapper.FromDatabase(x));
            return list;
        }
        public void DeleteKorisnik(int id)
        {
            while (_dbContext.Eventis.Where(x => x.Organizator.Equals(id)).FirstOrDefault() != null)
            {
               
                var kor = _dbContext.Eventis.Where(x => x.Organizator.Equals(id)).FirstOrDefault();
                DeleteVeze(kor.IdEvent);
                _dbContext.Eventis.Remove(kor);
                _dbContext.SaveChanges();
            }
            while (_dbContext.KorisnikEvents.Where(x => x.Korisnik.Equals(id)).FirstOrDefault() != null)
            {
                var kor = _dbContext.KorisnikEvents.Where(x => x.Korisnik.Equals(id)).FirstOrDefault();
                _dbContext.KorisnikEvents.Remove(kor);
                _dbContext.SaveChanges();
            }
            var user = _dbContext.Korisnicis.Where(x => x.IdKorisnik == id).FirstOrDefault();
            _dbContext.Korisnicis.Remove(user);
            _dbContext.SaveChanges();

        }
        public void DeleteVeze(int id)
        {
            while (_dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault() != null)
            {
                var kor = _dbContext.KorisnikEvents.Where(x => x.Event.Equals(id)).FirstOrDefault();
                _dbContext.KorisnikEvents.Remove(kor);
                _dbContext.SaveChanges();
            }
        }
        public void Edit(Models.Korisnici korisnik)
        {
            var dbCourse = KorisniciMapper.ToDatabase(korisnik);
            _dbContext.Korisnicis.Update(dbCourse);
            _dbContext.SaveChanges();
        }
        public async Task<Models.Korisnici> GetAsyncKorisnik(int id)
        {
            var result = await _dbContext.Korisnicis.SingleOrDefaultAsync(x => x.IdKorisnik == id);
      
            return KorisniciMapper.FromDatabase(result);
        }
    }
}
