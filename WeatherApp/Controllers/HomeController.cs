using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Services;
using Common.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _cityService;
        private List<CityWeather> cityInfo;
        public HomeController(IWeatherService service)
        {
            _cityService = service;
            cityInfo = _cityService.GetWeatherDetails();
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(cityInfo);
        }

        [Route("/weather/{cityCode}")]
        public IActionResult CityInfo(string cityCode)
        {
            

            CityWeather? weather = _cityService.GetWeatherByCityCode(cityCode);

            if (weather == null)
            {
                Response.StatusCode = 400;
                return View("Error");
            }

            return View(cityInfo.Where(city => city.CityUniqueCode == cityCode).FirstOrDefault());
        }
    }
}