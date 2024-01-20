using DataAccessLayer.Concrete;
using MediatR;
using Traversal.CQRS.Commands.GuideCommands;
using EntityLayer.Concrete;

namespace Traversal.CQRS.Handlers.GuideHandler
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guidess.Add(new Guide
            {
                Description = request.Description,
                Name = request.Name,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
