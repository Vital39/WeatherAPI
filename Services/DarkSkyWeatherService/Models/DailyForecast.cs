using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.BusinessModels
{
    public class DailyForecast
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("temperatureMin")]
        public double TemperatureMin { get; set; }     

        [JsonProperty("temperatureMax")]
        public double TemperatureMax { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }
}
