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
            var dateTime = GetDateTime(unixTime);
            string mounth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);           
            return $"{dateTime.Day} {mounth.Substring(0, 3)} {dateTime.Year}";
        }
        public string GetTime(long unixTime)
        {
            var dateTime = GetDateTime(unixTime);
            return $"{dateTime.Hour}:{dateTime.Minute}";
        }
        public string GetWeekDay(long unixTime)
        {
            var dateTime = GetDateTime(unixTime);
            var weekDay = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            return $"{weekDay}";
        }

        public string GetNumberAndMonth(long unixTime)
        {
            var dateTime = GetDateTime(unixTime);
            string mounth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);
            return $"{dateTime.Day} {mounth}";
        }

        private DateTime GetDateTime(long unixTime)
        {
            var dateTime = DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
            return dateTime;
        }
    }
}
