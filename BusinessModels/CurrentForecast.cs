using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.BusinessModels
{
    public class CurrentForecast
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }
    }
    }

