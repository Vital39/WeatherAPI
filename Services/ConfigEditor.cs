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
        public void SetLoaction(Location location)
        {   
            if(location==null)
            {
                Properties.Settings.Default.Location = null;
                return;
            }
            Properties.Settings.Default.Location = JsonConvert.SerializeObject(location);
            Properties.Settings.Default.Save();
        }
        public Location GetLoaction()
        {
            var data = Properties.Settings.Default.Location;
            if (data == null)
                return null;
            Location location = JsonConvert.DeserializeObject<Location>(data);
            return location;
        }
    }
}
