using Microsoft.AspNetCore.Mvc;
using Weather.Web.Models;

namespace Weather.Web.Controllers
{
    public class WeathersController : Controller
    {
        //List<CityWeather> CityList = new List<CityWeather>();
        CityWeather cityWeather = new CityWeather();
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(cityWeather.CityLists);
        }

        [HttpGet]
        [Route("/weathers/{cityCode}")]
        public IActionResult Details(string CityUniqueCode)
        {
            CityWeather city = cityWeather.CityLists.Where(x => x.CityUniqueCode == CityUniqueCode).FirstOrDefault();
            return View(city);
        }
    }
}
