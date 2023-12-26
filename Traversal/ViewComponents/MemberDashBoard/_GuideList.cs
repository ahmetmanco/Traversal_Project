using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashBoard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EFGuideDal());
        public IViewComponentResult Invoke(int id)
        {
            var value = guideManager.TGetList();
            return View();
        }
    }
}
