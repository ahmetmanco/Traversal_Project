using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactUsManager contactUsManager = new ContactUsManager(new EFContactUsDal());
        public IActionResult Index()
        {
            return View();
        }
    }
}
