using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IRezervasyonService _rezervasyonService;

        public UserController(IAppUserService appUserService, IRezervasyonService rezervasyonService)
        {
            _appUserService = appUserService;
            _rezervasyonService = rezervasyonService;
        }

        public IActionResult Index()
        {
            var value = _appUserService.TGetList();
            return View(value);
        }

        public IActionResult DeleteUser(int id)
        {
            var value = _appUserService.TGetById(id);
            _appUserService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var value = _appUserService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }
        //[HttpPost]
        public IActionResult RezervasyonUser(int id)
        {
            var value =_rezervasyonService.GetListWithRezervasyonByAccepted(id);
            return View(value);
        }
    }
}
