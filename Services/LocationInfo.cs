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
        private readonly string ipServiceUrl = "https://ip-api.com/json";
        
        private ConfigEditor ConfigEditor = new ConfigEditor();
        public async Task<Location> GetCurrentLocation()
        {
            Location location = ConfigEditor.GetLoaction();
            if (location != null)
                return location;

            WebClient client = new WebClient();
           

            string result = await client.DownloadStringTaskAsync(ipServiceUrl);

            location = JsonConvert.DeserializeObject<Location>(result);
            return location;
        }

    }
}
