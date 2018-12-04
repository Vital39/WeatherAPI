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
        public Task<WeatherForecast> GetWeather()
        {
            throw new NotImplementedException();
        }
    }
}
