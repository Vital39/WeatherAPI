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
        public string GetShortDate(long unixTime, string timeZoneId)
        {
            var dateTime = GetDateTime(unixTime, timeZoneId=null);
            string mounth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);           
            return $"{dateTime.Day} {mounth.Substring(0, 3)} {dateTime.Year}";
        }
        public string GetTime(long unixTime, string timeZoneId)
        {
            var dateTime = GetDateTime(unixTime, timeZoneId=null);
            return $"{dateTime.Hour}:{dateTime.Minute}";
        }
        public string GetWeekDay(long unixTime, string timeZoneId)
        {
            var dateTime = GetDateTime(unixTime, timeZoneId=null);
            var weekDay = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            return $"{weekDay}";
        }

        public string GetNumberAndMonth(long unixTime, string timeZoneId)
        {
            var dateTime = GetDateTime(unixTime, timeZoneId=null);
            string mounth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);
            return $"{dateTime.Day} {mounth}";
        }

        private DateTime GetDateTime(long unixTime, string timeZoneId)
        {
            var dateTimeOff = DateTimeOffset.FromUnixTimeSeconds(unixTime);
            try
            {
                if (String.IsNullOrEmpty(timeZoneId))
                    throw new TimeZoneNotFoundException();
                var timeZone=TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                DateTime dateTime= TimeZoneInfo.ConvertTime(dateTimeOff, timeZone).UtcDateTime;
                return dateTime;
            }
            catch (TimeZoneNotFoundException)
            {
                return dateTimeOff.LocalDateTime;
            }
        }
    }
}
