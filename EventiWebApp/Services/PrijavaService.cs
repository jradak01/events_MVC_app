using EventiWebApp.DbModels;
using EventiWebApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.Services
{
    public class PrijavaService
    {
        public PrijavaRepository _prijavaRepository;

        public PrijavaService(PrijavaRepository prijavaRepository)
        {
            _prijavaRepository = prijavaRepository;
        }

        public int RegistrirajKorisnika(Models.Korisnici korisnik)
        {
            return _prijavaRepository.RegistrirajKorisnika(korisnik);
        }

        public Models.Korisnici VerificirajKorisnika(string ime, string prezime, string korisnickoIme, string loz, string loz2, string email)
        {
            if (korisnickoIme == null || ime == null || prezime == null || loz == null || loz2 == null || email == null)
            {
                //Console.WriteLine("Error. Missing input values!");
                return null;
            }
            else if (korisnickoIme.Length <= 1 || ime.Length <= 1 || prezime.Length <= 1 || loz != loz2 || loz.Length < 5)
            {
                return null;
            }
            if (!_prijavaRepository.KorisnikPostoji(korisnickoIme))
                return new Models.Korisnici(null, ime, prezime, korisnickoIme, loz, email, false);
            return null;
        }

        public Models.Korisnici PrijavaKorisnik(string korisnickoIme, string lozinka)
        {
            return _prijavaRepository.PrijaviKorisnik(korisnickoIme, lozinka);
        }
    }
}
