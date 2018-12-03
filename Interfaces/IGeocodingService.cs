using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Models.Geocoding;

namespace WeatherApp.Interfaces
{
    interface IGeocodingService
    {
         Task<IList<FormattedAddress>> GetFormattedAddress(string city_adrress);
    }
}
