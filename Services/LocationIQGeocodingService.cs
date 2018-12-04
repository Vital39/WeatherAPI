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
using WeatherApp.Models.LocationIQGeocoding;

namespace WeatherApp.Services
{
    public class LocationIQGeocodingException : Exception
    {
        public LocationIQGeocodingException() : base()
        {
        }
        public LocationIQGeocodingException(string message) : base(message)
        {
        }
    }

    public class LocationIQGeocodingService : IGeocodingService
    {
        public async Task<IList<FormattedAddress>> GetFormattedAddressAsync(string cityAdrress)
        {
            string requestUri = string.Format("https://eu1.locationiq.com/v1/search.php?key=a43d65b56a1a62&city={0}&format=json&addressdetails=1", Uri.EscapeDataString(cityAdrress));
            try
            {
                WebClient webClient = new WebClient();
                string result = await webClient.DownloadStringTaskAsync(requestUri);
                List<LocationIQGeocodeResult> locationIQGeocodeResults = JsonConvert.DeserializeObject<List<LocationIQGeocodeResult>>(result);
                List<FormattedAddress> formattedAddresses = locationIQGeocodeResults.Select(r => new FormattedAddress
                {
                    CityName = r.Address.City,
                    Town = r.Address.Town,
                    CountryName =r.Address.Country,
                    Latitude = r.Lat,
                    Longtitude = r.Lon
                }).ToList();
                return formattedAddresses;
            }
            catch (WebException e)
            {
                throw new LocationIQGeocodingException(e.Message);
            }

            
        }
    }
}
