using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager _destinationManager = new DestinationManager(new EFDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = _destinationManager.TGetList();
            return View(values);
        }
        //[HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            ViewBag.i = id;
            ViewBag.j = id;
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Id = values.Id; 
            var value = _destinationManager.TGetDestinationWithGuide(id);
            return View(value);
        }
        //[HttpPost]
        //public IActionResult Details(Destination p)
        //{
        //    return View();
        //}
    }
}
