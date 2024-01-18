using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Traversal.CQRS.Queries.destinationQuery;
using Traversal.CQRS.Results.DestinationResult;

namespace Traversal.CQRS.Handlers.DestinationHandler
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var value = _context.Destinationss.Select(x => new GetAllDestinationQueryResult
            {
                Id = x.Id,
                Capacity = x.Capacity,
                City = x.City,
                Daynight = x.DayNight,
                Price = x.Price
            }).AsNoTracking().ToList();
            return value;
        }
    }
}
