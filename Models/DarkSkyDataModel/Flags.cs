using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models.DarkSkyRequest
{
    public class Flags
    {
        [JsonProperty("sources")]
        public IList<string> Sources { get; set; }

        [JsonProperty("meteoalarm-license")]
        public string MeteoalarmLicense { get; set; }

        [JsonProperty("nearest-station")]
        public double NearestStation { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }
}
