using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.Geocoding
{
    public class Result
    {

        [JsonProperty("address_components")]
        public IList<AddressComponent> Address_components { get; set; }

        [JsonProperty("formatted_address")]
        public string Formatted_address { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("place_id")]
        public string Place_id { get; set; }

        [JsonProperty("types")]
        public IList<string> Types { get; set; }
    }
}
