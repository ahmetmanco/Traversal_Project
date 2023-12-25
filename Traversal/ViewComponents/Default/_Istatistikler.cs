using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Istatistikler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinationss.Count();
            ViewBag.v2 = c.Guidess.Count();
            ViewBag.v3 = "3890";
            return View();
        }
    }
}
