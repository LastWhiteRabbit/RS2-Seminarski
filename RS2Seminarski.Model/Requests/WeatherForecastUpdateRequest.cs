﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.Requests
{
    public class WeatherForecastUpdateRequest
    {
        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}
