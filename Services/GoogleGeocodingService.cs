using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Interfaces;
using WeatherApp.Models.Geocoding;

namespace WeatherApp.Services
{
    class GoogleGeocodingService :IGeocodingService
    {
        public async Task<IList<FormattedAddress>> GetFormattedAddress(string city_adrress)
        {
            string requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/json?address={0}&sensor=false", Uri.EscapeDataString(city_adrress));
            try
            {
                WebClient webClient = new WebClient();
                string result = await webClient.DownloadStringTaskAsync(requestUri);
                List<Result> resultList = JsonConvert.DeserializeObject<List<Result>>(result);
                List<FormattedAddress> formattedAddresses = (List<FormattedAddress>)resultList.Select(rl => new FormattedAddress
                {
                    CityName = rl.Address_components.Where(ac => ac.Types.Contains("locality")).FirstOrDefault().Long_name,
                    CountryName = rl.Address_components.Where(ac => ac.Types.Contains("country")).FirstOrDefault().Long_name,
                    Latitude = rl.Geometry.Location.Lat,
                    Longtitude = rl.Geometry.Location.Lng
                });
                return formattedAddresses;
            }
            catch (WebException)
            {

                throw;
            }
            
            throw new NotImplementedException();
        }
    }
}
