using DataAccessLayer.Concrete;
using MediatR;
using Traversal.CQRS.Queries.GuideQueries;
using Traversal.CQRS.Results.GuideResult;

namespace Traversal.CQRS.Handlers.GuideHandler
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Guidess.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                Name = value.Name
            };
        }
    }
}
