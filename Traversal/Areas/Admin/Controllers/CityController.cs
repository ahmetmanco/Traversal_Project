using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Traversal.Models;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(Cityes);
            return View(jsonCity);
        }
        public static List<CityClass> Cityes = new List<CityClass>()
        { new CityClass()
            {
            Id = 1,
            CityName = "Üsküp",
            CityCountry = "Makedonya"
            },
            new CityClass()
            {
            Id = 2,
            CityName = "Roma",
            CityCountry = "İtalya"
            },
            new CityClass()
            {
            Id = 3,
            CityName = "Londra",
            CityCountry = "İngiltere"
            }
        };
    }
}
