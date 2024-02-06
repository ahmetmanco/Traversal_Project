using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Destination
{
    public class _GuideDetails : ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var value = _guideService.TGetById(id);
            return View(value);
        }
    }
}
