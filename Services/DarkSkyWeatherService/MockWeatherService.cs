using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Interfaces;

namespace WeatherApp.Services.DarkSkyWeatherService
{
    public class MockWeatherService : IWeatherService
    {
        public Task<WeatherForecast> GetWeather()
        {
           return Task.Run(() => {
               return new WeatherForecast()
               {
                   Latitude = 42.3601,
                   Longitude = 71.0589,
                   Timezone = "America / New_York",
                   CurrentForecast = new CurrentForecast()
                   {
                       Time = 1509993277,
                       Icon = "rain",
                       Summary = "Drizzle",
                       Temperature = 66.1
                   },
                   WeekForecast = new WeekForecast()
                   {
                       Summary = "Drizzle",
                       Icon = "rain",
                       WeekForecasts = new List<DailyForecast>()
                       {
                           new DailyForecast ()
                           {
                               Time = 1509991200,
                               Icon = "rain",
                               TemperatureMin = 4.23,
                               TemperatureMax = 52.08,
                               WindSpeed = 66.35
                           },
                           new DailyForecast ()
                           {
                               Time = 1509991200,
                               Icon = "rain",
                               TemperatureMin = 4.23,
                               TemperatureMax = 50.18,
                               WindSpeed = 62.35
                           },
                           new DailyForecast ()
                           {
                               Time = 1509991200,
                               Icon = "rain",
                               TemperatureMin = 4.23,
                               TemperatureMax = 50.18,
                               WindSpeed = 62.35
                           },
                          new DailyForecast ()
                           {
                               Time = 1509991200,
                               Icon = "rain",
                               TemperatureMin = 4.23,
                               TemperatureMax = 50.18,
                               WindSpeed = 62.35
                           },
                          new DailyForecast ()
                           {
                               Time = 1509991200,
                               Icon = "rain",
                               TemperatureMin = 4.23,
                               TemperatureMax = 50.18,
                               WindSpeed = 62.35
                           },
                          new DailyForecast ()
                           {
                               Time = 1509991200,
                               Icon = "rain",
                               TemperatureMin = 4.23,
                               TemperatureMax = 50.18,
                               WindSpeed = 62.35
                           },
                          new DailyForecast ()
                           {
                               Time = 1509991200,
                               Icon = "rain",
                               TemperatureMin = 4.23,
                               TemperatureMax = 50.18,
                               WindSpeed = 62.35
                           }
                       }
                   }
               };
           });
        }
    }
}
