using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager guideManager = new GuideManager(new EFGuideDal());
        public IActionResult Index()
        {
            var value = guideManager.TGetList();
            return View(value);
        }
    }
}
