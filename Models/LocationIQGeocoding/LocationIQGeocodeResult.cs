using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeatherApp.Models.LocationIQGeocoding
{
    public class LocationIQGeocodeResult
    {
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public LocationIQAddressComponents Address { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}

