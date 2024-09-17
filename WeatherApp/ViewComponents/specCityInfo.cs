using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Common.Models;

namespace WeatherApp.ViewComponents
{
    public class specCityInfo : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync (CityWeather model_city)
        {
            return View(model_city);
        }
    }
}