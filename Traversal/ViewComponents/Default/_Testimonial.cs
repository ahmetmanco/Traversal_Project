using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager manager = new TestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var value = manager.TGetList();
            return View(value);
        }
    }
}
