using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IPLocation.Model
{
    public class GeoLocationIP
    {
       

       [JsonProperty("city")]
        public string City { get; set; }

    }
}
