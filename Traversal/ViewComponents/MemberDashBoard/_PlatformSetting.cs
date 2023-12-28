using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashBoard
{
    public class _PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
