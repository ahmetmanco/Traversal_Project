using DataAccessLayer.Concrete;
using Traversal.CQRS.Queries.DestinationQuery;
using Traversal.CQRS.Results.DestinationResult;

namespace Traversal.CQRS.Handlers.DestinationHandler
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query) 
        {
            var value = _context.Destinationss.Find(query.Id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = value.Id,
                City = value.City,
                DayNight = value.DayNight,
                Price = value.Price

            };
        }
    }
}
