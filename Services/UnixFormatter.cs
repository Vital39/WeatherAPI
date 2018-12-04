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
        private UnixConverter converter=new UnixConverter();
        private DateTime dateTime; 
        public UnixFormatter(long unixTime)
        {
            dateTime= this.converter.UnixTimeToDatetime(unixTime);
        }

        public string GetShortDate()
        {
            string mounth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month);
            
            return $"{dateTime.Day} {mounth.Substring(0, 3)} {dateTime.Year}";
            
        }
    }
}
