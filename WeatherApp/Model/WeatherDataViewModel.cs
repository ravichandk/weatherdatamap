using System;

namespace WeatherApp.Model
{
    public class WeatherDataViewModel
    {
        public string Date => DateTime.UtcNow.ToShortDateString();

        public string City { get; set; }

        public string OverallDescription { get; set; }

        public double? TemperatureInCelsius { get; set; }

        public double? TemperatureInFarenheit { get; set; }

        public string Sunrise { get; set; }

        public string Sunset { get; set; }
        public string Base { get; internal set; }
    }
}
