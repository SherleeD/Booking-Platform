using Microsoft.EntityFrameworkCore;
using Booking.Persistence;
using System.Threading.Tasks;

namespace Booking.Application.RoomRental.Commands.DeleteRoomRental
{
    public class DeleteRoomRentalCommand : IDeleteRoomRentalCommand
    {
        public readonly BookingContext _context;

        public DeleteRoomRentalCommand(BookingContext context)
        {
            _context = context;
        }

        public async Task Execute(string id)
        {
            var entity = await _context.RoomRentals.SingleAsync(r => r.RoomRentalID.ToString() == id);

            _context.RoomRentals.Remove(entity);

            await _context.SaveChangesAsync();
        }

    }
}
