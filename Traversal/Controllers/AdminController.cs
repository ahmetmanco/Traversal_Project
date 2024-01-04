using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{ //adminLayout'taki tüm html kodlarını parçalara ayırıp buradaki viewlara dağıtacağız
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialAppBrandDemo()
        {
            return PartialView();
        }

        public PartialViewResult PartialSliderBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
        
        public PartialViewResult PartialFooterBar()
        {
            return PartialView();
        }
    }
}
