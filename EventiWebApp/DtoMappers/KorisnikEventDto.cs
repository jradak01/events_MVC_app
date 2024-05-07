using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.DtoMappers
{
    public class KorisnikEventDto
    {
        public static Models.KorisnikEvent FromJson(JObject json)
        {
            var id = json["IdKorisnikEvent"].ToObject<int?>();
            var Event = json["Event"].ToObject<int>();
            var korisnik = json["Korisnik"].ToObject<int>();
            var potvrdeno = json["Potvrdeno"].ToObject<bool?>();
            var recenzija = json["Recenzija"].ToObject<int?>();

            return new Models.KorisnikEvent(id, Event, korisnik, potvrdeno, recenzija);
        }
    }
}
