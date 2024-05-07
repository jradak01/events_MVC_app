using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.DtoMappers
{
    public class KorisnikDto
    {
        public static Models.Korisnici FromJson(JObject json)
        {
            var id = json["IdKorisnik"].ToObject<int?>();
            var ime = json["ime"].ToObject<string>();
            var prezime = json["prezime"].ToObject<string>();
            var korisnickoIme = json["korisnickoIme"].ToObject<string>();
            var lozinka = json["lozinka"].ToObject<string>();
            var email = json["email"].ToObject<string>();
            var admin = json["admin"].ToObject<bool>();

            return new Models.Korisnici(id, ime, prezime, korisnickoIme, lozinka, email, admin);
        }
    }
}
