using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class ConfigEditor
    {
        private const string locationKey = "location";
        public void SetLoaction(Location location)
        {
            ConfigurationManager.AppSettings[locationKey] = JsonConvert.SerializeObject(location);
        }
        public Location GetLoaction()
        {
            var data = ConfigurationManager.AppSettings[locationKey];
            if (data == null)
                return null;
            Location location = JsonConvert.DeserializeObject<Location>(data);
            return location;
        }
    }
}
