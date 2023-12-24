using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager _destinationManager = new DestinationManager(new EFDestinationDal());
        public IActionResult Index()
        {
            var values = _destinationManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.i = id;
            var value = _destinationManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Details(Destination p)
        {
            return View();
        }
    }
}
