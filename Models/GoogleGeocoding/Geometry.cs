using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.Geocoding
{
    public class Geometry
    {

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("location_type")]
        public string Location_type { get; set; }

        [JsonProperty("viewport")]
        public Viewport Viewport { get; set; }
    }

}
