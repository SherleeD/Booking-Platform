using Microsoft.EntityFrameworkCore;
using Booking.Persistence;
using System.Threading.Tasks;

namespace Booking.Application.Room.Commands.UpdateRoom
{
    public class UpdateRoomCommand : IUpdateRoomCommand
    {
        public readonly BookingContext _context;

        public UpdateRoomCommand(BookingContext context)
        {
            _context = context;
        }

        public async Task Execute(UpdateRoomModel model)
        {
            var entity = await _context.Rooms.SingleAsync(r => r.RoomId == model.RoomId);

            entity.Title = model.Title;
            entity.ImagePath = model.ImagePath;
            entity.RoomImage = model.RoomImage;
            entity.Price = model.Price;
            entity.Description = model.Description;
            entity.Address = model.Address;
            entity.Capacity = model.Capacity;
            entity.Status = model.Status;

            _context.Rooms.Update(entity);

            await _context.SaveChangesAsync();
        }

    }
}
