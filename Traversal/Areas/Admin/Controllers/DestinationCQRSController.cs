using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.CQRS.Commands.DestinationCommands;
using Traversal.CQRS.Handlers.DestinationHandler;
using Traversal.CQRS.Queries.DestinationQuery;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _queryHandler;
        private readonly GetDestinationByIdQueryHandler _queryIdHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        public DestinationCQRSController(GetAllDestinationQueryHandler queryHandler, GetDestinationByIdQueryHandler queryIdHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _queryHandler = queryHandler;
            _queryIdHandler = queryIdHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var value = _queryHandler.Handle();
            return View(value);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var value = _queryIdHandler.Handle(new GetDestinationByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommands commands)
        {
             _updateDestinationCommandHandler.Handle(commands);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }
    }
}
