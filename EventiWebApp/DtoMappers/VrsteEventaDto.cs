using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventiWebApp.DtoMappers
{
    public class VrsteEventaDto
    {
        public static Models.VrsteEventa FromJson(JObject json)
        {
            var id = json["IdVrsta"].ToObject<int>();
            var naziv = json["naziv"].ToObject<string>();

            return new Models.VrsteEventa(id, naziv);
        }
    }
}
