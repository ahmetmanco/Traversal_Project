using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Traversal.CQRS.Queries.GuideQueries;
using Traversal.CQRS.Results.GuideResult;

namespace Traversal.CQRS.Handlers.GuideHandler
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guidess.Select(x => new GetAllGuideQueryResult
            {
                Id = x.Id,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name,
            }).AsNoTracking().ToListAsync();
        }
    }
}
