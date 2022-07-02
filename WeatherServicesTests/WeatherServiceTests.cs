using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Impl;

namespace WeatherServicesTests
{
    [TestClass]
    public class WeatherServiceTests
    {
        [TestMethod]
        public void FetchWeatherData()
        {
            var city = "London";

            var weatherService = new WeatherService();
            var weatherData = weatherService.FetchWeatherData(city);

            Assert.IsNotNull(weatherData);
            Assert.AreEqual(weatherData.Name, city);
        }
    }

    public class MockHttpClientService : IHttpClientService
    {
        public string FetchData(string url)
        {
            return "Test";
        }
    }
}
