using Microsoft.AspNetCore.Mvc;
using Traversal.CQRS.Handlers.DestinationHandler;

namespace Traversal.Areas.Admin.Controllers
{
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _queryHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler queryHandler)
        {
            _queryHandler = queryHandler;
        }

        public IActionResult Index()
        {
            var value = _queryHandler.Handle();
            return View(value);
        }
    }
}
