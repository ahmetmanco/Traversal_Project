using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager _destinationManager = new DestinationManager(new EFDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = _destinationManager.TGetList();
            return View(values);
        }
    }
}
