using DataAccessLayer.Concrete;
using Traversal.CQRS.Commands.DestinationCommands;

namespace Traversal.CQRS.Handlers.DestinationHandler
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommands commandHandler)
        {
            var value = _context.Destinationss.Find(commandHandler.Id);
            value.City = commandHandler.City;
            value.DayNight = commandHandler.DayNight;
            value.Price = commandHandler.Price;
            value.Capacity = commandHandler.Capacity;

            _context.SaveChanges();
        }
    }
}
