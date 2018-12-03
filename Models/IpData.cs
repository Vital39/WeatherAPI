using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class IpData
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_rus")]
        public string CountryRus { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_rus")]
        public string RegionRus { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_rus")]
        public string CityRus { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }
    }

}
