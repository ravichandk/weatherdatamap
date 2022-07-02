using Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Services.Impl
{
    public interface IWeatherService
    {
        WeatherData FetchWeatherData(string city);
    }

    public class WeatherService : IWeatherService
    {
        public WeatherService(IHttpClientService httpClientService)
        {

        }

        public WeatherData FetchWeatherData(string city)
        {
            WeatherData weatherData = null;

            var url = @$"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=02ebee3c9a21db50b26de1a5dd0a88a1&units=metric&mode=json";
            
            var weatherInfo = HttpClientService.FetchData(url);

            weatherData = new WeatherDataConverter().ConvertToModel(weatherInfo);

            return weatherData;
        }
    }
}
