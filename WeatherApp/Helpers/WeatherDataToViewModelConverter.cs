using Models;
using System;
using WeatherApp.Model;

namespace WeatherApp.Helpers
{
    public class WeatherDataToViewModelConverter
    {
        public static WeatherDataViewModel Convert(WeatherData weatherData)
        {
            if (weatherData == null) return null;

            var sunrise = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(weatherData.Sys.Sunrise).TimeOfDay;
            var sunset = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(weatherData.Sys.Sunset).TimeOfDay;

            return new WeatherDataViewModel
            {
                City = weatherData.Name,
                OverallDescription = weatherData?.Weather?[0].Description,
                TemperatureInCelsius = weatherData?.Main?.Temperature,
                TemperatureInFarenheit = (weatherData?.Main?.Temperature * 1.8) + 32,
                Sunrise = new DateTime(sunrise.Ticks).ToString("hh:mm:ss tt"),
                Sunset = new DateTime(sunset.Ticks).ToString("hh:mm:ss tt")
            };
        }
    }
}
