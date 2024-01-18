
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace Traversal.CQRS.Handlers.DestinationHandler
{
    public class CreateDestinationCommand
    {
        private readonly Context _context;

        public CreateDestinationCommand(Context context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinationss.Add(new Destination
            {
                //City = command.City,
                //Price = command.Price,
                //DayNight = command.Daynight,
                //Capacity = command.Capacity
            });
        }
    }
}
