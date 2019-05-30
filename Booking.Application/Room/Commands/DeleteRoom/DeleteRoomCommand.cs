using Microsoft.EntityFrameworkCore;
using Booking.Persistence;
using System.Threading.Tasks;

namespace Booking.Application.Room.Commands.DeleteRoom
{
    public class DeleteRoomCommand :IDeleteRoomCommand
    {
        public readonly BookingContext _context;

        public DeleteRoomCommand(BookingContext context)
        {
            _context = context;
        }

        public async Task Execute(string id)
        {
            var entity = await _context.Rooms.SingleAsync(r => r.RoomId.ToString() == id);

            _context.Rooms.Remove(entity);

            await _context.SaveChangesAsync();
        }

    }
}
