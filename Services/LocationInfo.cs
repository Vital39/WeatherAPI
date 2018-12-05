using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class LocationInfo : IGetLocationServices
    {
        private readonly string api2Ip = "https://api.2ip.ua";
        private readonly string geoJsonData = "geo.json";

        public async Task<Location> GetCurrentLocation()
        {
            Location location = new ConfigEditor().GetLoaction();
            if (location != null)
                return location;

            WebClient client = new WebClient();
            client.BaseAddress = api2Ip;

            string result = await client.DownloadStringTaskAsync(geoJsonData);

            location = JsonConvert.DeserializeObject<Location>(result);
            return location;
        }

    }
}
