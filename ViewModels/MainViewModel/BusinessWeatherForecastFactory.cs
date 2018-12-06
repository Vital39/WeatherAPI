using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WeatherApp.BusinessModels;
using WeatherApp.Properties;
using WeatherApp.Services;

namespace WeatherApp.ViewModels.MainViewModels
{
    public class BusinessWeatherForecastFactory
    {
        private UnixFormatter formatter = new UnixFormatter();

        public BusinessWeatherForecast Make(WeatherForecast weatherForecast)
        {
            var bitmap = Resources.ResourceManager.GetObject(weatherForecast.CurrentForecast.Icon) as Bitmap;
            var bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                bitmap.GetHbitmap(),
                IntPtr.Zero,
                System.Windows.Int32Rect.Empty,
                BitmapSizeOptions.FromWidthAndHeight(100, 100));

            BusinessWeatherForecast forecast = new BusinessWeatherForecast
            {
                Date = formatter.GetNumberAndMonth(weatherForecast.CurrentForecast.Time),
                Time = formatter.GetTime(weatherForecast.CurrentForecast.Time),
                Temperature = Convert.ToInt32(((weatherForecast.CurrentForecast.Temperature - 32) * 5 / 9)).ToString(),
                WindSpeed = weatherForecast.CurrentForecast.WindSpeed.ToString(),
                CloudCover = weatherForecast.CurrentForecast.Summary,
                Icon = bitmapSource,

                WeekForecast = weatherForecast.WeekForecast.WeekForecasts.Select(df => new BusinessDailyForecast
                {
                    DayWeek = formatter.GetWeekDay(df.Time),
                    Date = formatter.GetShortDate(df.Time),
                    RangeTemperature = df.TemperatureMin.ToString()+"-"+df.TemperatureMax.ToString(),
                    WindSpeed = df.WindSpeed.ToString(),
                    Icon = Application.Current.Resources[df.Icon]
                }).ToList(),
            };
            return forecast;
        }
    }
}
