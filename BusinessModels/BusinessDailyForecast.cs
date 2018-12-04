using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.BusinessModels
{
    public class BusinessDailyForecast
    {
        public string DayWeek { get; set; }
        public string Date { get; set; }
        public string RangeTemperature { get; set; }
        public string Icon { get; set; }
        public string WindSpeed { get; set; }

    }
}
