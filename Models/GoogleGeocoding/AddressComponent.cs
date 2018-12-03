using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.Geocoding
{
    public class AddressComponent
    {

        [JsonProperty("long_name")]
        public string Long_name { get; set; }

        [JsonProperty("short_name")]
        public string Short_name { get; set; }

        [JsonProperty("types")]
        public IList<string> Types { get; set; }
    }
}
