using Booking.Domain;
using Booking.Persistence;
using System.Threading.Tasks;

namespace Booking.Application.Room.Commands.CreateRoom
{
    public class CreateRoomCommand : ICreateRoomCommand
    {
        public readonly BookingContext _context;

        public CreateRoomCommand(BookingContext context)
        {
            _context = context;
        }

        public async Task Execute(CreateRoomModel model)
        {
            var entity = new Booking.Domain.Room  
            {
                Title = model.Title,
                ImagePath = model.ImagePath,
                RoomImage = model.RoomImage,
                Price = model.Price,
                Description = model.Description,
                Address = model.Address,
                Capacity = model.Capacity,
                Status = model.Status
            };

            _context.Rooms.Add(entity);

            await _context.SaveChangesAsync();
        }
    }
}
