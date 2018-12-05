using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Interfaces;

namespace WeatherApp.Services.DarkSkyWeatherService
{
    public class DarkSkyWeatherService : IWeatherService
    {
        IGetLocationServices locationService = new LocationInfo();
        public async Task<WeatherForecast> GetWeather()
        {
            try
            {
                var location = await locationService.GetCurrentLocation();
                string request = $"https://api.darksky.net/forecast/57b882ce9043fd1927f358ed1a0bb905/{location.Latitude},{location.Longitude}";
                WebClient webClient = new WebClient();
                string result = await webClient.DownloadStringTaskAsync(request);
                WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(result);
                return weatherForecast;
            }
            catch (WebException)
            {
                throw new WeatherServiceException();
            }
            catch(JsonSerializationException)
            {
                throw new WeatherServiceException();
            }
            catch(JsonReaderException)
            {
                throw new WeatherServiceException();
            }
        }
    }
}
