using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.BusinessModels
{
    public class FormattedAddress
    {
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Town { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }

        public override string ToString()
        {
            return $"{CountryName}, {(string.IsNullOrEmpty(CityName)?Town:CityName)} ";
        }
    }
}
