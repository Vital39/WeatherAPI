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
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("data")]
        public IList<DailyForecast> WeekForecasts { get; set; }
    }
}
