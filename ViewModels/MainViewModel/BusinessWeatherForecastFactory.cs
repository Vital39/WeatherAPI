using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.BusinessModels;
using WeatherApp.Services;


namespace WeatherApp.ViewModels.MainViewModels
{
    class BusinessWeatherForecastFactory
    {
        private UnixFormatter formatter = new UnixFormatter();

        public BusinessWeatherForecast Make(WeatherForecast weatherForecast)
        {
            BusinessWeatherForecast forecast = new BusinessWeatherForecast
            {
                Date = formatter.GetNumberAndMonth(weatherForecast.CurrentForecast.Time),
                Time = formatter.GetTime(weatherForecast.CurrentForecast.Time),
                Temperature = weatherForecast.CurrentForecast.Temperature.ToString(),
                WindSpeed = weatherForecast.CurrentForecast.WindSpeed.ToString(),
                CloudCover = weatherForecast.CurrentForecast.Summary,
                Icon = weatherForecast.WeekForecast.Icon + ".jpg"
            };
            return forecast;
        }
    }
}
