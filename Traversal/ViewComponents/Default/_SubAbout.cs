using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager _manager = new SubAboutManager(new EFSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var value = _manager.TGetList();
            return View(value);
        }
    }
}
