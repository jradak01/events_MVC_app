using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.DtoMappers
{
    public class EventiDto
    {
        
            public static Models.Eventi FromJson(JObject json)
            {
                var id = json["IdEvent"].ToObject<int?>();
                var naziv = json["naziv"].ToObject<string>();
                var vrijeme = json["vrijeme"].ToObject<System.DateTime>();
                var mjesto = json["mjesto"].ToObject<int>();
                var adresa = json["adresa"].ToObject<string>();
                var cijena = json["cijena"].ToObject<string>();                                                                                                                 
                var vrsta = json["vrstaEventa"].ToObject<int>();
                var organizator = json["organizator"].ToObject<int>();
                var ograniceniPosjetitelji = json["ograniceniPosjetitelji"].ToObject<bool>();

                return new Models.Eventi(id, naziv, vrijeme, mjesto, adresa, cijena, vrsta, organizator, ograniceniPosjetitelji);
            }
        
    }
}
