namespace Traversal.CQRS.Queries.DestinationQuery
{
    public class GetDestinationByIdQuery
    {
        public GetDestinationByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }

    }
}
