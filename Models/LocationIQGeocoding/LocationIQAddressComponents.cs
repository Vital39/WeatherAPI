using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.LocationIQGeocoding
{
    public class LocationIQAddressComponents
    {
      
            [JsonProperty("city")]
            public string City { get; set; }
            
            [JsonProperty("postcode")]
            public string Postcode { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("country_code")]
            public string CountryCode { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }
        
    }
}
