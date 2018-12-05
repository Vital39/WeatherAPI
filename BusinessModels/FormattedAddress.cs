﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.BusinessModels
{
    public class FormattedAddress
    {
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Town { get; set; }
        public Location Location { get; set; }
    }
}
