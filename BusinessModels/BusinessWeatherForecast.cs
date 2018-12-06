using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WeatherApp.BusinessModels
{
    public class BusinessWeatherForecast
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Temperature { get; set; }
        public BitmapSource Icon { get; set; }
        public string WindSpeed { get; set; }
        public string CloudCover { get; set; }
        public List<BusinessDailyForecast> WeekForecast { get; set; }
    }
}
