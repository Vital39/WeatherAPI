using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.BusinessModels
{
    public class WeekForecast
    {
        [JsonProperty("summary")]
        public string summary { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }

        [JsonProperty("data")]
        public IList<DailyForecast> WeekForecasts { get; set; }
    }
}
