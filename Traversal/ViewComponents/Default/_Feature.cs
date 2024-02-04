using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager _featureManager = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values = _featureManager.TGetList();
            //ViewBag.image1 = _featureManager.ge
            //foreach (var item in _featureManager.TGetList())
            //{
            //    ViewBag.image = _featureManager.TGetList(item.Title);
            //}.
            return View();
        }
    }
}
