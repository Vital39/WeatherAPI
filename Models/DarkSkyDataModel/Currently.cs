using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.DarkSkyRequest
{
    public class Currently
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("precipIntensity")]
        public int PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public int PrecipProbability { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windBearing")]
        public int WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public int CloudCover { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }
    }
}
