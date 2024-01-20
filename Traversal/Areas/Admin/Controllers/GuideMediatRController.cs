using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.CQRS.Commands.GuideCommands;
using Traversal.CQRS.Queries.GuideQueries;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _mediator.Send(new GetAllGuideQuery());
            return View(value);
        }
        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var value = await _mediator.Send(new GetGuideByIdQuery(id));
            return View(value);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
           return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
