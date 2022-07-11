using Microsoft.AspNetCore.Mvc;
using Models;
using Services.Impl;
using WeatherApp.Helpers;
using WeatherApp.Model;

namespace WeatherApp.Controllers
{
    [Route("api/v1.0/weather")]
    [ApiController]
    public class WeatherDataController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherDataController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public WeatherDataViewModel GetWeatherData(string city)
        {
            //var weatherData = _weatherService.FetchWeatherData(city);

            //var weatherDataViewModel = WeatherDataToViewModelConverter.Convert(weatherData);
            //return weatherDataViewModel;

            return new WeatherDataViewModel
            {
                City = "London",
                OverallDescription = "London Weather"
            };
        }
    }
}
