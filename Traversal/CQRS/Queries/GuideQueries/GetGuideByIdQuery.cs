using MediatR;
using Traversal.CQRS.Results.GuideResult;

namespace Traversal.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery : IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }
    }
}
