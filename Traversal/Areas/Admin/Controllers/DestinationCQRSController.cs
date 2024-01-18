using Microsoft.AspNetCore.Mvc;
using Traversal.CQRS.Handlers.DestinationHandler;
using Traversal.CQRS.Queries.DestinationQuery;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _queryHandler;
        private readonly GetDestinationByIdQueryHandler _queryIdHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler queryHandler, GetDestinationByIdQueryHandler queryIdHandler)
        {
            _queryHandler = queryHandler;
            _queryIdHandler = queryIdHandler;
        }

        public IActionResult Index()
        {
            var value = _queryHandler.Handle();
            return View(value);
        }

        public IActionResult GetDestination(int id)
        {
            var value = _queryIdHandler.Handle(new GetDestinationByIdQuery(id));
            return View(value);
        }
    }
}
