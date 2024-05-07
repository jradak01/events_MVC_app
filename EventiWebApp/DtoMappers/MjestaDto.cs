using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.DtoMappers
{
    public class MjestaDto
    {
        public static Models.Mjesta FromJson(JObject json)
        {
            var id = json["IdMjesto"].ToObject<int?>();
            var naziv = json["naziv"].ToObject<string>();

            return new Models.Mjesta(id, naziv);
        }
    }
}
