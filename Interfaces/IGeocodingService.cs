using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Models.Geocoding;

namespace WeatherApp.Interfaces
{
    public interface IGeocodingService
    {
         Task<IList<FormattedAddress>> GetFormattedAddressAsync(string city_adrress);
    }
}
