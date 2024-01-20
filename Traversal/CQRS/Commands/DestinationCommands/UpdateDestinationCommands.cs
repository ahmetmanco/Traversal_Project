namespace Traversal.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommands
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
