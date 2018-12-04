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
                Icon = weatherForecast.WeekForecast.Icon + ".jpg",
                BusinessDailyForecasts = weatherForecast.WeekForecast.WeekForecasts.Select(df => new BusinessDailyForecast
                {
                    DayWeek = formatter.GetWeekDay(df.Time),
                    Date = formatter.GetShortDate(df.Time),
                    RangeTemperature = df.TemperatureMin.ToString()+"-"+df.TemperatureMax.ToString(),
                    WindSpeed = df.WindSpeed.ToString(),
                    Icon = df.Icon + ".jpg"
                }).ToList(),
            };
            return forecast;
        }
    }
}
