using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class UnixFormatter
    {  
        public string GetShortDate(long unixTime)
        {
            var dateTime = DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
            string mounth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);           
            return $"{dateTime.Day} {mounth.Substring(0, 3)} {dateTime.Year}";
        }
        public string GetTime(long unixTime)
        {
            var dateTime = DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
            return $"{dateTime.Hour}:{dateTime.Minute}";
        }
    }
}
