
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Traversal.CQRS.Commands.DestinationCommands;

namespace Traversal.CQRS.Handlers.DestinationHandler
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinationss.Add(new Destination
            {
                City = command.City,
                Capacity = command.Capacity,
                DayNight = command.DayNight,
                Price = command.Price,
                Status = true
            }) ;
            _context.SaveChanges();
        }
    }
}
