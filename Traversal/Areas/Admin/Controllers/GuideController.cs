using BussinessLayer.Abstract;
using BussinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var value = _guideService.TGetList();
            return View(value);
        }
        [Route("AddGuide")]
        [HttpGet]
        public IActionResult AddGuide()
        {

            return View();
        }

        [Route("AddGuide")]
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
        [Route("EditGuide")]
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var value = _guideService.TGetById(id);
            return View(value);
        }
        [Route("EditGuide")]
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }


        [Route("ChangeToTrue/{id}")]
        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);
            return RedirectToAction("Index" ,"Guide", new {area = "Admin"});
        }


        [Route("ChangeToFalse/{id}")]
        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        //[Route("DeleteGuide")]
        public IActionResult DeleteGuide(int id)
        {
            var value = _guideService.TGetById(id);
            _guideService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
