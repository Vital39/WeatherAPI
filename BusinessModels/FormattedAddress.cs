using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models

namespace WeatherApp.BusinessModels
{
    public class FormattedAddress
    {
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Town { get; set; }
<<<<<<< HEAD
        public double Latitude { get; set; }
        public double Longtitude { get; set; }

        public override string ToString()
        {
            return $"{CountryName}, {(string.IsNullOrEmpty(CityName)?Town:CityName)} ";
        }
=======
        public Location Location { get; set; }
>>>>>>> master
    }
}
