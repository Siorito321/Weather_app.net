using ServiceContracts;
using System.Runtime;
using Common.Models;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        public CityWeather? GetWeatherByCityCode(string CityCode)
        {
            return GetWeatherDetails().Find(cw => cw.CityUniqueCode == CityCode);
        }

        public List<CityWeather> GetWeatherDetails()
        {
            return new List<CityWeather>()
            {
                new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = new DateTime(2030, 01, 01, 8, 0, 0),  TemperatureFahrenheit = 33},
                new CityWeather() {CityUniqueCode = "NYC", CityName = "New York", DateAndTime = new DateTime(2030, 01, 01, 3, 0, 0),  TemperatureFahrenheit = 60},
                new CityWeather() {CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = new DateTime(2030, 01, 01, 9, 0, 0),  TemperatureFahrenheit = 82}
            };
        }
    }
}
