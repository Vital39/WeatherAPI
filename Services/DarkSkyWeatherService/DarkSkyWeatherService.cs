using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Interfaces;
using WeatherApp.Models;

namespace WeatherApp.Services.DarkSkyWeatherService
{
    public class DarkSkyWeatherService : IWeatherService
    {
        
        IGetLocationServices locationService = new LocationInfo();
        public async Task<WeatherForecast> GetWeather()
        {
            Location location;
            try 
            {
                location = await locationService.GetCurrentLocation();
            }
            catch (LocationServiceExeption e)
            {
                Debug.WriteLine(e.Message);
                throw new LocationServiceExeption();
            }
           
            try
            {            
                var numberFormat = new NumberFormatInfo
                {
                    NumberDecimalSeparator = "."
                };
                string latitude = location.Latitude.ToString(numberFormat);
                string longitude = location.Longitude.ToString(numberFormat);
                string request = $"https://api.darksky.net/forecast/57b882ce9043fd1927f358ed1a0bb905/{latitude},{longitude}";
                WebClient webClient = new WebClient();
                string result = await webClient.DownloadStringTaskAsync(request);
                WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(result);
                return weatherForecast;
            }
            catch (WebException e)
            {
                Debug.WriteLine(e.Message);
                throw new WeatherServiceException();
            }
            catch(JsonSerializationException e)
            {
                Debug.WriteLine(e.Message);
                throw new WeatherServiceException();
            }
            catch(JsonReaderException e)
            {
                Debug.WriteLine(e.Message);
                throw new WeatherServiceException();
            }
        }
    }
}
